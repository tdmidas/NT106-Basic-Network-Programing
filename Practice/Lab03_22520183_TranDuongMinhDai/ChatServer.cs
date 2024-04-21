using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_22520183_TranDuongMinhDai
{
    public partial class ChatServer : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private Thread listenThread;
        public ChatServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, 8080);
            server.Start();
            listenThread = new Thread(ListenForClients);
            listenThread.Start();
            button1.Text = "Listening";
            richTextBox1.AppendText("Server is listening on port 8080...\n");
        }
        private void ListenForClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                clients.Add(client);

                string clientInfo = "New client connected from " + ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString() + ":" + ((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString();
                 richTextBox1.AppendText(clientInfo + "\n");
                Thread clientThread = new Thread(HandleClient);
                clientThread.Start(client);
            }
        }

        private void HandleClient(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {               
                bytesRead = clientStream.Read(message, 0, 4096);
                string receivedMessage = Encoding.ASCII.GetString(message, 0, bytesRead);
                BroadcastMessage(receivedMessage);
                richTextBox1.AppendText(receivedMessage + "\n");
            }


        }

        private void BroadcastMessage(string message)
        {
            foreach (TcpClient client in clients)
            {
                NetworkStream clientStream = client.GetStream();
                byte[] broadcastMessage = Encoding.ASCII.GetBytes(message);
                clientStream.Write(broadcastMessage, 0, broadcastMessage.Length);
            }
        }

      
    }
}
