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
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
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
            
            
            if(double.TryParse(textBox1.Text.Trim(),out double num1)&&
               double.TryParse(textBox2.Text.Trim(),out double num2)&&
               double.TryParse(textBox3.Text.Trim(),out double num3))
            {

                double max = Math.Max(Math.Max(num1, num2), num3);
                string max_format = string.Format("", max);
                max_textbox.Text = max_format.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hoặc số thực!");
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
