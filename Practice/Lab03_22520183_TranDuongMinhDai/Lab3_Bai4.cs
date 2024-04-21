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
    public partial class Lab3_Bai4 : Form
    {
        public Lab3_Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatClient client = new ChatClient();
            client.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatServer server = new ChatServer();
            server.Show();
        }
    }
}
