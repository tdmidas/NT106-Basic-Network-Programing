﻿namespace Lab03_22520183_TranDuongMinhDai
{
    partial class Lab3_Bai4
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
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(99, 77);
            button1.Name = "button1";
            button1.Size = new Size(147, 57);
            button1.TabIndex = 0;
            button1.Text = "Chat client";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(310, 77);
            button2.Name = "button2";
            button2.Size = new Size(134, 57);
            button2.TabIndex = 1;
            button2.Text = "Chat server";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Lab3_Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 237);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lab3_Bai4";
            Text = "Lab3_Bai4";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}