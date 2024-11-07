using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Ogrenci
    {
        public int OgrenciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Sehir { get; set; }
        public int Sinif { get; set; }

        public Ogrenci()
        {
            
        }

        public Ogrenci(int ogrenciID, string ad, string soyad, int yas, string sehir, int sinif)
        {
            OgrenciID = ogrenciID;
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            Sehir = sehir;
            Sinif = sinif;
        }
    }
}
