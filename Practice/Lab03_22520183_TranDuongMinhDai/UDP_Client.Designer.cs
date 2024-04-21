namespace Lab03_22520183_TranDuongMinhDai
{
    partial class UDP_Client
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
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(294, 45);
            label4.Name = "label4";
            label4.Size = new Size(171, 41);
            label4.TabIndex = 17;
            label4.Text = "UDP Client";
            // 
            // button2
            // 
            button2.Location = new Point(413, 365);
            button2.Name = "button2";
            button2.Size = new Size(123, 40);
            button2.TabIndex = 16;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(193, 365);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 15;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(122, 222);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(557, 120);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(122, 189);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 13;
            label3.Text = "Send message";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(447, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(406, 130);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 10;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(122, 130);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 9;
            label1.Text = "IP Address";
            // 
            // UDP_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UDP_Client";
            Text = "UDP_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}