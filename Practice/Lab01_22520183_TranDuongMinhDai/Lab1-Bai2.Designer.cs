namespace Lab01_22520183_TranDuongMinhDai
{
    partial class Lab1_Bai2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            clear = new Button();
            exit = new Button();
            find = new Button();
            max_textbox = new TextBox();
            min_textbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 47);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Số 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 50);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Số 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 53);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Số 3";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(361, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(600, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.GradientActiveCaption;
            clear.Location = new Point(341, 194);
            clear.Name = "clear";
            clear.Size = new Size(96, 37);
            clear.TabIndex = 6;
            clear.Text = "Xóa";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // exit
            // 
            exit.BackColor = SystemColors.GradientActiveCaption;
            exit.Location = new Point(515, 194);
            exit.Name = "exit";
            exit.Size = new Size(107, 37);
            exit.TabIndex = 7;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // find
            // 
            find.BackColor = SystemColors.GradientActiveCaption;
            find.Location = new Point(165, 194);
            find.Name = "find";
            find.Size = new Size(104, 37);
            find.TabIndex = 8;
            find.Text = "Tìm";
            find.UseVisualStyleBackColor = false;
            find.Click += find_Click;
            // 
            // max_textbox
            // 
            max_textbox.Location = new Point(149, 311);
            max_textbox.Name = "max_textbox";
            max_textbox.ReadOnly = true;
            max_textbox.Size = new Size(120, 27);
            max_textbox.TabIndex = 9;
            // 
            // min_textbox
            // 
            min_textbox.Location = new Point(497, 315);
            min_textbox.Name = "min_textbox";
            min_textbox.ReadOnly = true;
            min_textbox.Size = new Size(125, 27);
            min_textbox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 37);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 11;
            label4.Text = "Số lớn nhất";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 40);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 12;
            label5.Text = "Số nhỏ nhất";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 99);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các giá trị";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(43, 278);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(695, 94);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // Lab1_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(min_textbox);
            Controls.Add(max_textbox);
            Controls.Add(find);
            Controls.Add(exit);
            Controls.Add(clear);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Lab1_Bai2";
            Text = "Lab1_Bai2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button clear;
        private Button exit;
        private Button find;
        private TextBox max_textbox;
        private TextBox min_textbox;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}