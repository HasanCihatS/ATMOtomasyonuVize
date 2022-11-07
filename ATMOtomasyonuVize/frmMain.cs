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

                try
                {
                string guncelBakiye = File.ReadLines($"./MusteriLoglari/BANKA-{musteri.MusteriAdi}-LOG.txt").Last();
                musteri.Bakiye = Convert.ToInt32(guncelBakiye.Split(":")[1].ToString());

                }
                catch(Exception e)
                {

                }


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
            else
            {
                if (comboBox1.SelectedItem.ToString() == "Para Çek")
                {
                    StreamWriter streamWriter = new StreamWriter($"./MusteriLoglari/BANKA-{musteri.MusteriAdi}-LOG.txt", true);
                    streamWriter.WriteLine("Para Çekildi");
                    streamWriter.WriteLine($"Eski Bakiye: {musteri.Bakiye}");
                    musteri.Bakiye -= Convert.ToInt32(textMiktar.Text);
                    streamWriter.WriteLine($"Yeni Bakiye: {musteri.Bakiye}\n\n\n");
                    streamWriter.Close();
                    MessageBox.Show("Para Çekildi.");
                }
                if (comboBox1.SelectedItem.ToString() == "Para Ekle")
                {
                    StreamWriter streamWriter = new StreamWriter($"./MusteriLoglari/BANKA-{musteri.MusteriAdi}-LOG.txt", true);
                    streamWriter.WriteLine("Para Eklendi");
                    streamWriter.WriteLine($"Eski Bakiye: {musteri.Bakiye}");
                    musteri.Bakiye += Convert.ToInt32(textMiktar.Text);
                    streamWriter.WriteLine($"Yeni Bakiye: {musteri.Bakiye}\n\n\n");
                    streamWriter.Close();

                    MessageBox.Show("Para Eklendi.");
                }
                if (comboBox1.SelectedItem.ToString() == "Bakiye Sorgula")
                {
                    MessageBox.Show($"Güncel Bakiye: {musteri.Bakiye}");
                }
            }

           

            textMusteriAdiATM.Text = null;
            textMiktar.Text = null;

        }

        private void comboMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Musteri musteri = ((Musteri)comboMusteriler.SelectedValue);
            richTextBox1.Text = File.ReadAllText($"./MusteriLoglari/BANKA-{musteri.MusteriAdi}-LOG.txt");
        }
    }
}