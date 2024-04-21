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
    public partial class TCP_Listener : Form
    {
        private TcpListener server;
        private bool isServerRunning = false;
        private Thread serverThread;

        public TCP_Listener()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private async void ListenForClients()
        {
            while (isServerRunning)
            {
                try
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        richTextBox1.AppendText(message+"\n");

                    }
                    client.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void StartServer()
        {
            try
            {
                int port = int.Parse(textBox2.Text.Trim());

                server = new TcpListener(IPAddress.Any, port);
                server.Start();

                
                isServerRunning = true;
                serverThread = new Thread(new ThreadStart(ListenForClients));
                serverThread.Start();
                richTextBox1.AppendText($"Server running on port {port}\n");
                ListenForClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void StopServer()
        {
            isServerRunning = false;
            server.Stop();
            serverThread.Join();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isServerRunning)
            {
                StopServer();
                button1.Text = "Start Server";
            }
            else
            {
                StartServer();
                button1.Text = "Stop Server";
            }
                
             
        }
    }
}
