namespace Lab03_22520183_TranDuongMinhDai
{
    partial class TCP_Listener
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
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(346, 94);
            button1.Name = "button1";
            button1.Size = new Size(109, 42);
            button1.TabIndex = 2;
            button1.Text = "Start server";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(165, 26);
            label1.Name = "label1";
            label1.Size = new Size(191, 41);
            label1.TabIndex = 4;
            label1.Text = "TCP Listener";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 105);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 5;
            label2.Text = "Port";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(103, 175);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(352, 285);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // TCP_Listener
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 493);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Name = "TCP_Listener";
            Text = "TCP_Listener";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}