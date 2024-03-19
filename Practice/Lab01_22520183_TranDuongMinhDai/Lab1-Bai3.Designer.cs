namespace Lab01_22520183_TranDuongMinhDai
{
    partial class Lab1_Bai3
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
            read_button = new Button();
            clear_button = new Button();
            exit_button = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(137, 23);
            label1.Name = "label1";
            label1.Size = new Size(187, 41);
            label1.TabIndex = 0;
            label1.Text = "Đọc số (0-9)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(68, 104);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 1;
            label2.Text = "Nhập số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(68, 154);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // read_button
            // 
            read_button.BackColor = SystemColors.GradientActiveCaption;
            read_button.Location = new Point(43, 230);
            read_button.Name = "read_button";
            read_button.Size = new Size(99, 44);
            read_button.TabIndex = 3;
            read_button.Text = "Đọc";
            read_button.UseVisualStyleBackColor = false;
            read_button.Click += read_button_Click;
            // 
            // clear_button
            // 
            clear_button.BackColor = SystemColors.GradientActiveCaption;
            clear_button.Location = new Point(182, 230);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(98, 44);
            clear_button.TabIndex = 4;
            clear_button.Text = "Xóa";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // exit_button
            // 
            exit_button.BackColor = SystemColors.GradientActiveCaption;
            exit_button.Location = new Point(332, 230);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(94, 44);
            exit_button.TabIndex = 5;
            exit_button.Text = "Thoát";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 154);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(154, 27);
            textBox2.TabIndex = 7;
            // 
            // Lab1_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 361);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(exit_button);
            Controls.Add(clear_button);
            Controls.Add(read_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab1_Bai3";
            Text = "Lab1_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button read_button;
        private Button clear_button;
        private Button exit_button;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}