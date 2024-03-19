namespace Lab01_22520183_TranDuongMinhDai
{
    partial class Lab1_Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(323, 19);
            label1.Name = "label1";
            label1.Size = new Size(193, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản lý điểm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 93);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 3;
            label2.Text = "Danh sách điểm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(136, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 165);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách môn học và điểm";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(6, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(558, 120);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox3);
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Location = new Point(136, 382);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(585, 179);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.Control;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Location = new Point(320, 39);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(244, 120);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Control;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(12, 39);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(244, 120);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(288, 140);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(422, 140);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Location = new Point(546, 140);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Lab1_Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Lab1_Bai5";
            Text = "Lab1_Bai5";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button2;
        private Button button3;
    }
}