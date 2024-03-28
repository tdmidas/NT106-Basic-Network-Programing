namespace Lab2_22520183_TranDuongMinhDai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab2_Bai1 lab2_Bai1 = new Lab2_Bai1();
            lab2_Bai1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Lab2_Bai2 lab2_Bai2 = new Lab2_Bai2();
            lab2_Bai2.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Lab2_Bai3 lab2_Bai3 = new Lab2_Bai3();
            lab2_Bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab2_Bai4 lab2_Bai4 = new Lab2_Bai4();  
            lab2_Bai4.Show();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Lab2_Bai5 lab2_bai5 = new Lab2_Bai5();
            lab2_bai5.Show();

        }
    }
}
