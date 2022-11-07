using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMOtomasyonuVize
{
    public class Musteri : KullaniciHesabi
    {
        public string MusteriAdi { get; set; }
        public string MusteriSifre { get; set; }
        public int Bakiye { get; set; }
    }
}
