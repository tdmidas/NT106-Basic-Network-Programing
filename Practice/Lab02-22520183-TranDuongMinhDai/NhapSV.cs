using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_22520183_TranDuongMinhDai
{
    public partial class NhapSV : Form
    {
        public NhapSV()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường thông tin đã được điền đầy đủ chưa
            if (string.IsNullOrEmpty(nameBox.Text)||
                string.IsNullOrEmpty(mssvBox.Text) || !Regex.IsMatch(mssvBox.Text, "^[0-9]+$")||              
                string.IsNullOrEmpty(sdtBox.Text) || !Regex.IsMatch(sdtBox.Text, "^[0-9]+$") ||
                (double.Parse(mathBox.Text) < 0 || double.Parse(mathBox.Text) > 10) || 
                (double.Parse(vanBox.Text) < 0 || double.Parse(vanBox.Text) > 10))
            {
                MessageBox.Show("Vui lòng nhập chính xác thông tin.");
                return;
            }
            
            string saveUrl = "F:\\1.UIT\\NT106-Basic Network Programing\\Practice\\Lab2-22520183-TranDuongMinhDai\\input.txt";
            // Ghi thông tin sinh viên vào file input.txt
            using (StreamWriter writer = new StreamWriter(saveUrl))
            {
                string studentInfo = $"{mssvBox.Text};{nameBox.Text};{sdtBox.Text};{mathBox.Text};{vanBox.Text};";
                writer.WriteLine(studentInfo);
                MessageBox.Show("Đã thêm thông tin sinh viên vào file input.txt.");
            }

            nameBox.Clear();
            mssvBox.Clear();
            sdtBox.Clear();
            mathBox.Clear();
            vanBox.Clear();

        }
    }
}
