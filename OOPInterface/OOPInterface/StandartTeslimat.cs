using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterface
{
    public class StandartTeslimat : ITeslimat
    {
        public void PaketTeslimEt(string adres)
        {
            Console.WriteLine($"Standart teslimat: Paket {adres} adresine 3-5 iş günü içinde teslim edilecektir.");
        }
    }
}
