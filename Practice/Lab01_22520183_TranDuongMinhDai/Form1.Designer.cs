namespace Lab01_22520183_TranDuongMinhDai
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(149, 89);
            button1.Name = "button1";
            button1.Size = new Size(135, 48);
            button1.TabIndex = 0;
            button1.Text = "Bài 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(464, 89);
            button2.Name = "button2";
            button2.Size = new Size(134, 48);
            button2.TabIndex = 1;
            button2.Text = "Bài 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(149, 207);
            button3.Name = "button3";
            button3.Size = new Size(135, 50);
            button3.TabIndex = 2;
            button3.Text = "Bài  3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(464, 207);
            button4.Name = "button4";
            button4.Size = new Size(134, 50);
            button4.TabIndex = 3;
            button4.Text = "Bài 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(299, 294);
            button5.Name = "button5";
            button5.Size = new Size(143, 59);
            button5.TabIndex = 4;
            button5.Text = "Bài 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 27);
            label1.Name = "label1";
            label1.Size = new Size(250, 41);
            label1.TabIndex = 5;
            label1.Text = "22520183_Lab01";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}
