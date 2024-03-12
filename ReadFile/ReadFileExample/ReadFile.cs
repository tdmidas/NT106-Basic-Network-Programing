using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ReadFileExample
{
    public partial class ReadFile : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FileStream fs;
        string content;
        byte[] bytes;
        public ReadFile()
        {
            InitializeComponent();
        }
        // Cách đọc sử dụng FileStream
        private void btnFileStream_Click(object sender, EventArgs e)
        {
            // Hiển thị Hộp thoại OpenFileDialog cho phép chọn 1 file
            // Thuộc tính FileName của OpenFileDialog trả về đường dẫn của file
            ofd.ShowDialog();
            fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            bytes = new byte[fs.Length];
            // Đọc nội dung từ đầu cho đến cuối
            fs.Read(bytes, 0, (int)fs.Length);
            content = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
            richTextBox1.Text = content;
            fs.Close();
        }

        // Cách đọc sử dụng StreamReader
        private void btnStreamReader_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            StreamReader str = new StreamReader(ofd.FileName);
            content = str.ReadToEnd();
            richTextBox1.Text = content;
            str.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private async void btnFileReadAsync_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            using (FileStream fs = File.Open(ofd.FileName, FileMode.Open))
            {
                bytes = new Byte[fs.Length];
                await fs.ReadAsync(bytes, 0, (int)fs.Length);
            }
            richTextBox1.Text = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
        }

        private async void btnStreamReadAsync_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            using (StreamReader sr = new StreamReader(ofd.FileName))
            {
                Char[] bytes = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(bytes, 0, (int)sr.BaseStream.Length);
            }
            richTextBox1.Text = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
        }

        private void ReadFile_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


