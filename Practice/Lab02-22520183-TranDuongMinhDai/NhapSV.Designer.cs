namespace Lab2_22520183_TranDuongMinhDai
{
    partial class NhapSV
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
            nameBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            mssvBox = new TextBox();
            sdtBox = new TextBox();
            mathBox = new TextBox();
            vanBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 24);
            label1.Name = "label1";
            label1.Size = new Size(270, 38);
            label1.TabIndex = 0;
            label1.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 92);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(120, 94);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(291, 27);
            nameBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 142);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 3;
            label3.Text = "MSSV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 188);
            label4.Name = "label4";
            label4.Size = new Size(47, 28);
            label4.TabIndex = 4;
            label4.Text = "SĐT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 236);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 5;
            label5.Text = "Điểm Toán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 291);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 6;
            label6.Text = "Điểm Văn";
            // 
            // mssvBox
            // 
            mssvBox.Location = new Point(122, 142);
            mssvBox.Name = "mssvBox";
            mssvBox.Size = new Size(291, 27);
            mssvBox.TabIndex = 8;
            // 
            // sdtBox
            // 
            sdtBox.Location = new Point(120, 192);
            sdtBox.Name = "sdtBox";
            sdtBox.Size = new Size(291, 27);
            sdtBox.TabIndex = 9;
            // 
            // mathBox
            // 
            mathBox.Location = new Point(123, 240);
            mathBox.Name = "mathBox";
            mathBox.Size = new Size(291, 27);
            mathBox.TabIndex = 10;
            // 
            // vanBox
            // 
            vanBox.Location = new Point(122, 291);
            vanBox.Name = "vanBox";
            vanBox.Size = new Size(291, 27);
            vanBox.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(166, 362);
            button1.Name = "button1";
            button1.Size = new Size(138, 52);
            button1.TabIndex = 13;
            button1.Text = "Nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NhapSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(button1);
            Controls.Add(vanBox);
            Controls.Add(mathBox);
            Controls.Add(sdtBox);
            Controls.Add(mssvBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NhapSV";
            Text = "NhapSV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox mssvBox;
        private TextBox sdtBox;
        private TextBox mathBox;
        private TextBox vanBox;
        private Button button1;
    }
}