using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab2
{
    public partial class Firmaekleme : Form
    {
        public int Id { get; set; }
        public string Firmaadi
        {
            get { return textBoxFirmaadi.Text; }
            set { textBoxFirmaadi.Text = value; }
        }
        public string Sifre
        {
            get { return textBoxSifre.Text; }
            set { textBoxSifre.Text = value; }
        }
        public string AracBilgisi
        {
            get { return textBoxAracBilgisi.Text; }
            set { textBoxAracBilgisi.Text = value; }
        }
        public Firmaekleme()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
