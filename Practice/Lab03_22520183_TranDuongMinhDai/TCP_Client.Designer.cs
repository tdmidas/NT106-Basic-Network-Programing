namespace Lab03_22520183_TranDuongMinhDai
{
    partial class TCP_Client
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
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(602, 471);
            button2.Name = "button2";
            button2.Size = new Size(94, 42);
            button2.TabIndex = 1;
            button2.Text = "Gửi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(91, 460);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(493, 67);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(449, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(259, 19);
            label1.Name = "label1";
            label1.Size = new Size(163, 41);
            label1.TabIndex = 6;
            label1.Text = "TCP Client";
            // 
            // button1
            // 
            button1.Location = new Point(602, 402);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 7;
            button1.Text = "Kết nối";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 109);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 8;
            label2.Text = "IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 109);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 9;
            label3.Text = "Port";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(91, 161);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(483, 280);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "";
            // 
            // TCP_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 543);
            Controls.Add(richTextBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Name = "TCP_Client";
            Text = "TCP_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox2;
    }
}