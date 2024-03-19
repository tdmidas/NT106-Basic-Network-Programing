using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_22520183_TranDuongMinhDai
{
    public partial class Lab1_Bai1 : Form
    {

        public Lab1_Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập một số!");
                return;
            }
            if (Int32.TryParse(textBox1.Text.Trim(), out int num1) && Int32.TryParse(textBox2.Text.Trim(), out int num2))
            {
                try
                {
                    checked
                    {
                        int sum;
                        sum = num1 + num2;
                        textBox3.Text = sum.ToString();
                    }
                }
                catch(OverflowException ex)
                {
                    MessageBox.Show("Xảy ra lỗi overflow!");
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập 2 số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập một số!");
                return;
            }
            if (Int32.TryParse(textBox1.Text.Trim(), out int num1) && Int32.TryParse(textBox2.Text.Trim(), out int num2))
            {
                int sub;
                sub = num1 - num2;
                textBox3.Text = sub.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập 2 số nguyên!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập một số!");
                return;
            }
            if (Int32.TryParse(textBox1.Text.Trim(), out int num1) && Int32.TryParse(textBox2.Text.Trim(), out int num2))
            {
                try
                {
                    checked
                    {
                        int mul;
                        mul = num1 * num2;
                        textBox3.Text = mul.ToString();
                    }
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập 2 số nguyên!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập một số!");
                return;
            }
            if (Int32.TryParse(textBox1.Text.Trim(), out int num1) && Int32.TryParse(textBox2.Text.Trim(), out int num2))
            {
                float div;
                float Num1 = Convert.ToSingle(num1);
                float Num2 = Convert.ToSingle(num2);
                div = Num1 / Num2;
                textBox3.Text = div.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập 2 số nguyên!");
            }
        }
    }
}
