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
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
        }
        private string NumberToWord(int number)
        {
            switch (number)
            {
                case 0:
                    return "Không";
                case 1:
                    return "Một";
                case 2:
                    return "Hai";
                case 3:
                    return "Ba";
                case 4:
                    return "Bốn";
                case 5:
                    return "Năm";
                case 6:
                    return "Sáu";
                case 7:
                    return "Bảy";
                case 8:
                    return "Tám";
                case 9:
                    return "Chín";
                default:
                    return "";
            }
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void read_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập một số!");
                return;
            }
            if (int.TryParse(textBox1.Text.Trim(), out int number) && number >= 0 && number <= 9)
            {
                textBox2.Text = NumberToWord(number).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên từ 0 đến 9.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }
    }
}
