﻿namespace WinFormsApp1
{
    partial class Like
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Like));
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1695, 904);
            button1.Name = "button1";
            button1.Size = new Size(168, 90);
            button1.TabIndex = 0;
            button1.Text = "СТРАННАЯ КНОПКА";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Like
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Name = "Like";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Like";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}