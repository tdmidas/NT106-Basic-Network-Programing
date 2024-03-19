using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab01_22520183_TranDuongMinhDai
{
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void find_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text)&&string.IsNullOrEmpty(textBox2.Text)&&string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập một số!");
                return;
            }
            if (float.TryParse(textBox1.Text.Trim(),out float num1)&&
               float.TryParse(textBox2.Text.Trim(),out float num2)&&
               float.TryParse(textBox3.Text.Trim(),out float num3)
               )
            {

                float max = Math.Max(Math.Max(num1, num2), num3);
                float min = Math.Min(Math.Min(num1,num2),num3);
                max_textbox.Text = max.ToString();
                min_textbox.Text = min.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hoặc số thực!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
