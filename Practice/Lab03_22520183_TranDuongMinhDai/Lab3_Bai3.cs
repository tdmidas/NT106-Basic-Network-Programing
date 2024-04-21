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
    public partial class Lab3_Bai3 : Form
    {
        public Lab3_Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCP_Client tcp_Client = new TCP_Client();
            tcp_Client.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TCP_Listener tcp_Listener = new TCP_Listener();
            tcp_Listener.Show();
        }
    }
}
