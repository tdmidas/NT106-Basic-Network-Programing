namespace Lab2_22520183_TranDuongMinhDai
{
    partial class Lab2_Bai3
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(289, 20);
            label1.Name = "label1";
            label1.Size = new Size(226, 35);
            label1.TabIndex = 0;
            label1.Text = "Đọc các phép tính";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(123, 77);
            button1.Name = "button1";
            button1.Size = new Size(102, 42);
            button1.TabIndex = 1;
            button1.Text = "Đọc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(78, 146);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(285, 261);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(411, 146);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(300, 261);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(314, 77);
            button2.Name = "button2";
            button2.Size = new Size(102, 42);
            button2.TabIndex = 6;
            button2.Text = "Tính";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(517, 77);
            button3.Name = "button3";
            button3.Size = new Size(102, 42);
            button3.TabIndex = 7;
            button3.Text = "Ghi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Lab2_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Lab2_Bai3";
            Text = "Lab2_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button2;
        private Button button3;
    }
}