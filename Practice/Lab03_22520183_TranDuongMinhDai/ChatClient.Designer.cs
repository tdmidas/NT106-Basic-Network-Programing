namespace Lab03_22520183_TranDuongMinhDai
{
    partial class ChatClient
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
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(312, 19);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 0;
            label1.Text = "Chat Client";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(60, 100);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(656, 244);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 370);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Your name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 438);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Message";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(60, 393);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 4;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(60, 470);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(490, 70);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(590, 481);
            button1.Name = "button1";
            button1.Size = new Size(99, 41);
            button1.TabIndex = 6;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(333, 391);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChatClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "ChatClient";
            Text = "ChatClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private Button button2;
    }
}