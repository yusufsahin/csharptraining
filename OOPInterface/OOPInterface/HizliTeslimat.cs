using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterface
{
    public class HizliTeslimat : ITeslimat
    {
        public void PaketTeslimEt(string adres)
        {
            Console.WriteLine($"Hızlı teslimat: Paket {adres} adresine 24 saat içinde teslim edilecektir.");

        }
    }
}
