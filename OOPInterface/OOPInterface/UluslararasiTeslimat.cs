using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterface
{
    public class UluslararasiTeslimat : ITeslimat
    {
        public void PaketTeslimEt(string adres)
        {
            Console.WriteLine($"Uluslararası teslimat: Paket {adres} adresine 7-14 iş günü içinde teslim edilecektir.");

        }
    }
}
