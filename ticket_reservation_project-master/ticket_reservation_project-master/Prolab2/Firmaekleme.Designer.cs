namespace Prolab2
{
    partial class Firmaekleme
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
            textBoxAracBilgisi = new TextBox();
            textBoxSifre = new TextBox();
            textBoxFirmaadi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(94, 159);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "iptal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(265, 159);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "tamam";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBoxAracBilgisi
            // 
            textBoxAracBilgisi.Location = new Point(94, 116);
            textBoxAracBilgisi.Name = "textBoxAracBilgisi";
            textBoxAracBilgisi.Size = new Size(265, 27);
            textBoxAracBilgisi.TabIndex = 2;
            textBoxAracBilgisi.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(94, 79);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(265, 27);
            textBoxSifre.TabIndex = 3;
            // 
            // textBoxFirmaadi
            // 
            textBoxFirmaadi.Location = new Point(94, 39);
            textBoxFirmaadi.Name = "textBoxFirmaadi";
            textBoxFirmaadi.Size = new Size(265, 27);
            textBoxFirmaadi.TabIndex = 4;
            textBoxFirmaadi.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 5;
            label1.Text = "Firma Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 6;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 116);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 7;
            label3.Text = "Araç Bilgisi:";
            // 
            // Firmaekleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 217);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFirmaadi);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxAracBilgisi);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Firmaekleme";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Firma Ekleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBoxAracBilgisi;
        private TextBox textBoxSifre;
        private TextBox textBoxFirmaadi;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}