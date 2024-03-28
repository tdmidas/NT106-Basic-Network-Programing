using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_22520183_TranDuongMinhDai
{
    public partial class Lab2_Bai5 : Form
    {
        public Lab2_Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = @"C:\";
            fbd.ShowDialog();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            
            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                textBox1.Text = fbd.SelectedPath;

                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                if (!di.Exists)
                {
                    MessageBox.Show("Thư mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DirectoryInfo[] directories = di.GetDirectories();
                foreach (DirectoryInfo directory in directories)
                {
                    listBox1.Items.Add($"📁 {directory.Name}");
                    listBox2.Items.Add(directory.LastWriteTime);
                    listBox3.Items.Add("File folder");
                    listBox4.Items.Add(" ");
                }
                FileInfo[] files = di.GetFiles();
                foreach (FileInfo file in files)
                {
                    listBox1.Items.Add($"📄 {file.Name}");
                    listBox2.Items.Add(file.LastWriteTime);
                    listBox3.Items.Add(file.Extension);
                    listBox4.Items.Add($"{file.Length} bytes");

                }

            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = Directory.GetParent(textBox1.Text);
            if (di != null)
            {
                textBox1.Text = di.FullName;

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                DirectoryInfo[] directories = di.GetDirectories();
                foreach (DirectoryInfo directory in directories)
                {
                    listBox1.Items.Add($"📁 {directory.Name}");
                    listBox2.Items.Add(directory.LastWriteTime);
                    listBox3.Items.Add("File folder");
                    listBox4.Items.Add(" ");
                }
                FileInfo[] files = di.GetFiles();
                foreach (FileInfo file in files)
                {
                    listBox1.Items.Add($"📄 {file.Name}");
                    listBox2.Items.Add(file.LastWriteTime);
                    listBox3.Items.Add(file.Extension);
                    listBox4.Items.Add($"{file.Length} bytes");

                }

            }
        }
    }
}
