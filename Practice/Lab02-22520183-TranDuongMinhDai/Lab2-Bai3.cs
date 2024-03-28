using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_22520183_TranDuongMinhDai
{
    public partial class Lab2_Bai3 : Form
    {
        public Lab2_Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.ShowDialog();
            string url = ofd.FileName;
            using (StreamReader sr = new StreamReader(url))
            {
                string content;
                content = sr.ReadToEnd();
                richTextBox1.AppendText(content);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.ShowDialog();
            string url = sfd.FileName;
            using (StreamWriter sw = new StreamWriter(url))
            {
                sw.Write(richTextBox2.Text);
            }

            MessageBox.Show("File save successfully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1.Lines;
            foreach (string line in lines)
            {

                string[] operands = line.Split(new char[] { '+', '-', '*', '/' });

                if (operands.Length != 2)
                {
                    MessageBox.Show($"Dòng không hợp lệ: {line}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double num1, num2;
                if (!double.TryParse(operands[0].Trim(), out num1) || !double.TryParse(operands[1].Trim(), out num2))
                {
                    MessageBox.Show($"Dữ liệu phải là số nguyên hoặc số thực: {line}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                char op = line[operands[0].Length];

                double result = 0;

                try
                {
                    switch (op)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 == 0)
                                throw new DivideByZeroException();
                            result = num1 / num2;
                            break;
                        default:
                            throw new ArgumentException("Phép toán không hợp lệ.");
                    }

                    richTextBox2.AppendText($"{line} = {result}" + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
