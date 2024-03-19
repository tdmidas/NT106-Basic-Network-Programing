using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Lab01_22520183_TranDuongMinhDai
{
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {


            InitializeComponent();
        }


        private string XepLoai(double averageScore, double[] numericScores)
        {
            if (averageScore >= 8 && !numericScores.Any(score => score < 6.5))
            {
                return "Giỏi";
            }
            else if (averageScore >= 6.5 && !numericScores.Any(score => score < 5))
            {
                return "Khá";
            }
            else if (averageScore >= 5 && !numericScores.Any(score => score < 3.5))
            {
                return "Trung bình";
            }
            else if (averageScore >= 3.5 && !numericScores.Any(score => score < 2))
            {
                return "Yếu";
            }
            else return "Kém";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Chỉnh lề
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox2.SelectionAlignment = HorizontalAlignment.Left;
            //Khai báo
            string input = textBox1.Text;
            string[] scores = input.Split(' ');
            double[] numericScores = new double[scores.Length];
            //Check xem đa có dữ liệu chưa
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập điểm!");
                return;
            }
            for (int i = 0; i < scores.Length; i++)
            {

                if (double.TryParse(scores[i], out numericScores[i])&&numericScores[i]<=10 && numericScores[i]>=0)
                {

                    richTextBox1.AppendText($"Môn {i + 1}: {numericScores[i]}đ \t");


                }
                else
                {
                    MessageBox.Show("Điểm nhập không hợp lệ!");
                    richTextBox1.Clear();
                    return;
                }
            }
            double averageScore = numericScores.Average();
            double maxScore = numericScores.Max();
            double minScore = numericScores.Min();
            int pass = numericScores.Count(score => score >= 5);
            int notPass = numericScores.Count(score => score < 5);

            richTextBox2.AppendText($"Điểm trung bình: {averageScore.ToString("F2")} \n \n");
            richTextBox2.AppendText($"Điểm cao nhất: {maxScore}  \n \n ");
            richTextBox2.AppendText($"Điểm nhỏ nhất: {minScore}  ");

            richTextBox3.AppendText($"Xếp loại học lực: {XepLoai(averageScore, numericScores)} \n \n");
            richTextBox3.AppendText($"Số môn đậu: {pass}  \n \n");
            richTextBox3.AppendText($"Số môn không đậu: {notPass}  ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
