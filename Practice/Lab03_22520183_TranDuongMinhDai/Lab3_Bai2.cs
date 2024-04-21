using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03_22520183_TranDuongMinhDai
{

    public partial class Lab3_Bai2 : Form
    {
        public Lab3_Bai2()
        {
            InitializeComponent();
        }

        private void StartThread()
        {
            richTextBox1.Text = "Server started\n";
            int bytesRecv = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;

            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepSV = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepSV);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();

             richTextBox1.Text += "Client connected\n";
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesRecv = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                }
                while (text[text.Length - 1] != '\n');
                richTextBox1.AppendText("Client: " + text);
            }
            listenerSocket.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            button1.Text ="Listening...";
            Thread severthread = new Thread(new ThreadStart(StartThread));
            severthread.Start();
        }
    }
}
