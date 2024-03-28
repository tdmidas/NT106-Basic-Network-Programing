using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_22520183_TranDuongMinhDai
{
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filenameBox.Text =ofd.SafeFileName;
            string url = ofd.FileName;
            urlBox.Text = url;


            using (StreamReader sr = new StreamReader(url))
            {

                string content = sr.ReadToEnd();
                richTextBox1.AppendText(content);
                charBox.Text = content.Length.ToString();
                string[] words = content.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
                wordBox.Text = words.Length.ToString();
                string[] lines = content.Split('\n');
                lineBox.Text = lines.Length.ToString();
               

            }


        }



    }
}

