namespace Prolab2
{
    public partial class AdminEkrani : Form
    {
        public int Id { get; set; }
        public AdminEkrani()
        {
            InitializeComponent();
            Id = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Firmaekleme yenifirmaekleme = new Firmaekleme();
            DialogResult result = yenifirmaekleme.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Add(Id++, yenifirmaekleme.Firmaadi, yenifirmaekleme.Sifre, yenifirmaekleme.AracBilgisi);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
            Firmaekleme firmaGuncelleme = new Firmaekleme();
            firmaGuncelleme.Firmaadi = dataGridViewRow.Cells[1].Value.ToString();
            firmaGuncelleme.Sifre = dataGridViewRow.Cells[2].Value.ToString();
            firmaGuncelleme.AracBilgisi = dataGridViewRow.Cells[3].Value.ToString();
            firmaGuncelleme.Id = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
            DialogResult result = firmaGuncelleme.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            dataGridViewRow.Cells[1].Value = firmaGuncelleme.Firmaadi;
            dataGridViewRow.Cells[2].Value = firmaGuncelleme.Sifre;
            dataGridViewRow.Cells[3].Value = firmaGuncelleme.AracBilgisi;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;

            }
            DialogResult result = MessageBox.Show(text: "Seçili satýr silinecektir onaylýyor musunuz?", caption: "uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) { return; }
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);


        }
    }
}
