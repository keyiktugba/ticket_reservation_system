﻿namespace Prolab2
{
    partial class giris
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
            label1 = new Label();
            label2 = new Label();
            textBoxkullaniciadi = new TextBox();
            textBoxSifre = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(317, 236);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "iptal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(515, 236);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "tamam";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 136);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 184);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // textBoxkullaniciadi
            // 
            textBoxkullaniciadi.Location = new Point(317, 133);
            textBoxkullaniciadi.Name = "textBoxkullaniciadi";
            textBoxkullaniciadi.Size = new Size(295, 27);
            textBoxkullaniciadi.TabIndex = 4;
            textBoxkullaniciadi.TextChanged += textBoxkullaniciadi_TextChanged;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(317, 181);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(292, 27);
            textBoxSifre.TabIndex = 5;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 320);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxkullaniciadi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "giris";
            Text = "giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBoxkullaniciadi;
        private TextBox textBoxSifre;
    }
}