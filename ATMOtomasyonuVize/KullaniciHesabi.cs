using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMOtomasyonuVize
{
    public class KullaniciHesabi
    {
        public void LogDosyasiOlustur(Musteri musteri)
        {
            string path = $"./MusteriLoglari/BANKA-{musteri.MusteriAdi}-LOG.txt";

            FileInfo fi = new FileInfo(path);
            if (!fi.Directory.Exists)
            {
                Directory.CreateDirectory(fi.DirectoryName);
            }

           StreamWriter streamWriter = (File.Exists(path)) ? File.AppendText(path) : File.CreateText(path);
        }

        public void HesapDosyasiOlustur(Musteri musteri)
        {
            string path = $"./MusteriHesaplari/BANKA-{musteri.MusteriAdi}.txt";
            //www.stackoverflow.com/questions/3814364/create-a-file-from-a-path-creating-subdirectories-if-they-not-exists
            FileInfo fi = new FileInfo(path);
            if (!fi.Directory.Exists)
            {
                Directory.CreateDirectory(fi.DirectoryName);
            }

            //www.stackoverflow.com/questions/10383053/create-file-if-file-does-not-exist
            using (StreamWriter streamWriter = (File.Exists(path)) ? File.AppendText(path) : File.CreateText(path))
            {
                streamWriter.WriteLine(musteri.MusteriAdi);
                streamWriter.WriteLine(musteri.MusteriSifre);
            }
        }
    }
}
