using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace ReadMultipleFile
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    using (StreamReader str = new StreamReader(fileName))
                    {
                        int lines = 0;
                        while (str.ReadLine() != null)
                        {
                            lines++;
                        }
                        richTextBox1.AppendText($"{fileName} has {lines} lines" + Environment.NewLine);
                    }
                }
            }
        }

        }
    }
