namespace Lab03_22520183_TranDuongMinhDai
{
    partial class UDP_Server
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
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(448, 98);
            button1.Name = "button1";
            button1.Size = new Size(129, 46);
            button1.TabIndex = 9;
            button1.Text = "Start listening";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(311, 17);
            label3.Name = "label3";
            label3.Size = new Size(167, 38);
            label3.TabIndex = 13;
            label3.Text = "UDP Server";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(286, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(337, 400);
            button2.Name = "button2";
            button2.Size = new Size(113, 34);
            button2.TabIndex = 12;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(219, 104);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 7;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(198, 159);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 11;
            label2.Text = "Received message";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(198, 196);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(404, 172);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // UDP_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Name = "UDP_Server";
            Text = "UDP_Server";
            Load += UDP_Server_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}