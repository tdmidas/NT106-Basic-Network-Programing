using System.Net.Sockets;
using System.Net;
using System.Text;

namespace UDPSocket_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            IPAddress ipadd = IPAddress.Parse(textBox1.Text);
            int port = Convert.ToInt32(textBox2.Text);
            IPEndPoint ipend = new IPEndPoint(ipadd, port);
            Byte[] sendBytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
            udpClient.Send(sendBytes, sendBytes.Length, ipend);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
