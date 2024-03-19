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
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputType = comboBox1.SelectedItem.ToString();
            string outputType = comboBox2.SelectedItem.ToString();
            string inputValue = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(inputValue))
            {
                MessageBox.Show("Vui lòng nhập một số!");
                return;
            }

            string result = "";
            try
            {
                if (inputType == outputType)
                {
                    result = inputValue;
                }
                else if (inputType == "Binary")
                {
                    if (outputType == "Decimal")
                        result = Convert.ToInt64(inputValue, 2).ToString();
                    else if (outputType == "Hex")
                        result = Convert.ToString(Convert.ToInt64(inputValue, 2), 16).ToUpper();
                }
                else if (inputType == "Decimal")
                {
                    if (outputType == "Binary")
                        result = Convert.ToString(Convert.ToInt64(inputValue), 2);
                    else if (outputType == "Hex")
                        result = Convert.ToString(Convert.ToInt64(inputValue), 16).ToUpper();
                }
                else if (inputType == "Hex")
                {
                    if (outputType == "Binary")
                        result = Convert.ToString(Convert.ToInt64(inputValue, 16), 2);
                    else if (outputType == "Decimal")
                        result = Convert.ToInt64(inputValue, 16).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            textBox2.Text = result;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
