using System.Collections.Generic;
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

        private void btnAtmOnayla_Click(object sender, EventArgs e)
        {
            Musteri musteri = banka.musteriler.Find(x => (x.MusteriAdi == textMusteriAdiATM.Text));

            if (musteri == null)
            {
                MessageBox.Show("Kullanýcý Bulunamadý.");
                return;
            }

            StreamWriter streamWriter = new StreamWriter($"./MusteriLoglari/BANKA-{musteri.MusteriAdi}-LOG.txt");
            streamWriter.WriteLine(comboBox1.SelectedItem.ToString() + " " + textMiktar.Text);
            streamWriter.Close();

            textMusteriAdiATM.Text = null;
            textMiktar.Text = null;

            MessageBox.Show(comboBox1.SelectedItem.ToString() + " Ýþlemi Baþarýlý");
        }
    }
}