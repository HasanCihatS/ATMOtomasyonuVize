using System.Text;
using System.Windows.Forms;

namespace ATMOtomasyonuVize
{
    public partial class frmMain : Form
    {
        Banka banka = new Banka();

        public frmMain()
        {
            InitializeComponent();

            KullanicilariOku();
            comboMusteriler.DataSource = banka.musteriler;
            comboMusteriler.DisplayMember = "MusteriAdi";
        }

        public void KullanicilariOku()
        {
            foreach (string path in Directory.GetFiles("./MusteriHesaplari"))
            {
                Musteri musteri = new Musteri();
                musteri.MusteriAdi = File.ReadLines(path).ElementAt(0);
                musteri.MusteriSifre = File.ReadLines(path).ElementAt(1);

                banka.musteriler.Add(musteri);
            }
            dataGridMusteriler.DataSource = null;
            dataGridMusteriler.DataSource = banka.musteriler;
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