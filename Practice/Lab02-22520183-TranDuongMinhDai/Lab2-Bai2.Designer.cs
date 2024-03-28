namespace Lab2_22520183_TranDuongMinhDai
{
    partial class Lab2_Bai2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            filenameBox = new TextBox();
            urlBox = new TextBox();
            lineBox = new TextBox();
            wordBox = new TextBox();
            charBox = new TextBox();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 90);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 150);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 207);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Số dòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 269);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "Số từ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 326);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Số ký tự";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(157, 381);
            button1.Name = "button1";
            button1.Size = new Size(115, 47);
            button1.TabIndex = 5;
            button1.Text = "Đọc file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // filenameBox
            // 
            filenameBox.Location = new Point(187, 87);
            filenameBox.Name = "filenameBox";
            filenameBox.ReadOnly = true;
            filenameBox.Size = new Size(125, 27);
            filenameBox.TabIndex = 6;
            // 
            // urlBox
            // 
            urlBox.Location = new Point(187, 147);
            urlBox.Name = "urlBox";
            urlBox.ReadOnly = true;
            urlBox.Size = new Size(125, 27);
            urlBox.TabIndex = 7;
            // 
            // lineBox
            // 
            lineBox.Location = new Point(187, 207);
            lineBox.Name = "lineBox";
            lineBox.ReadOnly = true;
            lineBox.Size = new Size(125, 27);
            lineBox.TabIndex = 8;
            // 
            // wordBox
            // 
            wordBox.Location = new Point(187, 269);
            wordBox.Name = "wordBox";
            wordBox.ReadOnly = true;
            wordBox.Size = new Size(125, 27);
            wordBox.TabIndex = 9;
            // 
            // charBox
            // 
            charBox.Location = new Point(187, 326);
            charBox.Name = "charBox";
            charBox.ReadOnly = true;
            charBox.Size = new Size(125, 27);
            charBox.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(378, 78);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(356, 371);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(291, 9);
            label6.Name = "label6";
            label6.Size = new Size(171, 38);
            label6.TabIndex = 12;
            label6.Text = "Đọc file .txt";
            // 
            // Lab2_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(charBox);
            Controls.Add(wordBox);
            Controls.Add(lineBox);
            Controls.Add(urlBox);
            Controls.Add(filenameBox);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab2_Bai2";
            Text = "Lab2_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox filenameBox;
        private TextBox urlBox;
        private TextBox lineBox;
        private TextBox wordBox;
        private TextBox charBox;
        private RichTextBox richTextBox1;
        private Label label6;
    }
}