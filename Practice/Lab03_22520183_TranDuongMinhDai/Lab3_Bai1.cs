using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_22520183_TranDuongMinhDai
{
    public partial class Lab3_Bai1 : Form
    {
        public Lab3_Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UDP_Client client = new UDP_Client();
            client.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UDP_Server server = new UDP_Server();
            server.Show();
        }
    }
}
