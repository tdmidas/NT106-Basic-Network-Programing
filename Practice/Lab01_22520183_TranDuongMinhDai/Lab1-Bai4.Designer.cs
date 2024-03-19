namespace Lab01_22520183_TranDuongMinhDai
{
    partial class Lab1_Bai4
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            exit_button = new Button();
            clear_button = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(224, 26);
            label1.Name = "label1";
            label1.Size = new Size(364, 38);
            label1.TabIndex = 0;
            label1.Text = "Chuyển đổi HEX, BIN, DEC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(148, 129);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 1;
            label2.Text = "Nhập một số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(197, 190);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 2;
            label3.Text = "Chọn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(430, 190);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 3;
            label4.Text = "sang";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(59, 165);
            button1.Name = "button1";
            button1.Size = new Size(163, 47);
            button1.TabIndex = 4;
            button1.Text = "Chuyển đổi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(264, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 349);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(294, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(162, 353);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 7;
            label5.Text = "Kết quả";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Binary", "Decimal", "Hex" });
            comboBox1.Location = new Point(264, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Binary", "Decimal", "Hex" });
            comboBox2.Location = new Point(498, 190);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(exit_button);
            groupBox1.Controls.Add(clear_button);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(89, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(641, 250);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // exit_button
            // 
            exit_button.BackColor = SystemColors.GradientActiveCaption;
            exit_button.Font = new Font("Segoe UI", 10F);
            exit_button.ForeColor = SystemColors.ControlText;
            exit_button.Location = new Point(440, 165);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(131, 47);
            exit_button.TabIndex = 6;
            exit_button.Text = "Thoát";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            // 
            // clear_button
            // 
            clear_button.BackColor = SystemColors.GradientActiveCaption;
            clear_button.Font = new Font("Segoe UI", 10F);
            clear_button.ForeColor = SystemColors.ControlText;
            clear_button.Location = new Point(256, 165);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(145, 47);
            clear_button.TabIndex = 5;
            clear_button.Text = "Xóa";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // Lab1_Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Lab1_Bai4";
            Text = "Lab1_Bai4";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private Button clear_button;
        private Button exit_button;
    }
}