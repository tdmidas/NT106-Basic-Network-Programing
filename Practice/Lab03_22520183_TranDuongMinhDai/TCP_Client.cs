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
    public partial class TCP_Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public TCP_Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string message = richTextBox1.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                richTextBox2.AppendText($"{message}\n");
                richTextBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            string ipAddress = textBox1.Text;
            int port = int.Parse(textBox2.Text);
            IPAddress ip = IPAddress.Parse(ipAddress);
            IPEndPoint endPoint = new IPEndPoint(ip, port);
            client.Connect(endPoint);
            stream = client.GetStream();
            button1.Text = "Connected";
            Thread Recv = new Thread(Receive);
            Recv.IsBackground = true;
            Recv.Start();
            byte[] data = Encoding.UTF8.GetBytes("Hello Server");
            stream.Write(data, 0, data.Length);
        }
        void Receive(Object obj)
        {
            while (true)
            {
                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string str = Encoding.UTF8.GetString(recv);
                richTextBox2.AppendText(str+"\n");

            }
        }
    }
}
