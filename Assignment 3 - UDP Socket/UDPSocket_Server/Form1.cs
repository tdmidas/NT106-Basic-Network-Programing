using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UDPSocket_Server
{

    public partial class Form1 : Form
    {
        Socket udpSocket;
        private bool isListening;
        private byte[] buffer = new byte[1024];

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            isListening = false;
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
            catch (ObjectDisposedException)
            {
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

        

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
