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

namespace Lab03_22520183_TranDuongMinhDai
{
    public partial class UDP_Client : Form
    {
        public UDP_Client()
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
    }
}
