namespace ATMOtomasyonuVize
{
    public partial class frmMain : Form
    {
        Banka banka = new Banka();

        public frmMain()
        {
            InitializeComponent();
        }

        private void buttonMusteriOlustur_Click(object sender, EventArgs e)
        {
            banka.MusteriEkle(textMusteriAdi.Text);

            textMusteriAdi.Text = null;

            dataGridMusteriler.DataSource = null;
            dataGridMusteriler.DataSource = banka.musteriler;
        }
    }
}