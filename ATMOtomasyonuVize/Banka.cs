using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMOtomasyonuVize
{
    public class Banka
    {
        public List<Musteri> musteriler = new List<Musteri>();

        public void MusteriEkle(string musteriAdi)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAdi = musteriAdi;
            musteri.MusteriSifre = SifreOlustur();

            musteriler.Add(musteri);

            musteri.HesapDosyasiOlustur(musteri);
            musteri.LogDosyasiOlustur(musteri);
        }


        //www.stackoverflow.com/questions/4616685/how-to-generate-a-random-string-and-specify-the-length-you-want-or-better-gene
        internal string SifreOlustur()
        {
            Random rd = new Random();
            const string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789";
            char[] chars = new char[16];

            for (int i = 0; i < 16; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    }
}
