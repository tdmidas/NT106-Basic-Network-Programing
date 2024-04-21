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
    public partial class UDP_Server : Form
    {
        Socket udpSocket;
        private bool isListening;
        private byte[] buffer = new byte[1024];
        public UDP_Server()
        {
            InitializeComponent();
        }
        private void StartListening()
        {
            udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            int port = Convert.ToInt32(textBox1.Text);
            udpSocket.Bind(new IPEndPoint(IPAddress.Any, port));
            EndPoint ipRec = new IPEndPoint(IPAddress.Any, 0);
            udpSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ipRec, ReceiveCallback, null);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                EndPoint ipRec = new IPEndPoint(IPAddress.Any, 0);
                int bytesRead = udpSocket.EndReceiveFrom(ar, ref ipRec);

                string mess = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                this.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.AppendText($"From {ipRec}: {mess}\r\n");
                });

                EndPoint newIpRec = new IPEndPoint(IPAddress.Any, 0);
                udpSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref newIpRec, ReceiveCallback, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isListening)
            {
                udpSocket.Close();
                isListening = false;
                button1.Text = "Start Listening";
            }
            else
            {
                StartListening();
                isListening = true;
                button1.Text = "Stop Listening";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            udpSocket.Close();
            isListening = false;
            button1.Text = "Start Listening";
            this.Close();
        }

        private void UDP_Server_Load(object sender, EventArgs e)
        {
            isListening = false;
        }
    }
}
