using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_22520183_TranDuongMinhDai
{
    public partial class ChatClient : Form
    {
        private TcpClient client;
        private NetworkStream clientStream;
        private byte[] message = new byte[4096];
        public ChatClient()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sendMessage = textBox1.Text+": "+ richTextBox2.Text ;
            byte[] sendMessageBytes = Encoding.ASCII.GetBytes(sendMessage);
            clientStream.Write(sendMessageBytes, 0, sendMessageBytes.Length);

        }
        private void ReceiveMessages()
        {
            int bytesRead;

            while (true)
            {
                bytesRead = clientStream.Read(message, 0, 4096);                      
                string receivedMessage = Encoding.ASCII.GetString(message, 0, bytesRead);
                richTextBox1.AppendText(receivedMessage + "\n");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            client.Connect("127.0.0.1", 8080);
            clientStream = client.GetStream();

            richTextBox1.AppendText("Connected to server\n");

            Thread receiveThread = new Thread(ReceiveMessages);
            receiveThread.Start();
        }
    }
}
