using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterface
{
    public class Siparis
    {
        private ITeslimat teslimatYontemi;

        public Siparis(ITeslimat teslimatYontemi)
        {
            this.teslimatYontemi = teslimatYontemi;
        }

        public void SiparisVer(string adres)
        {
            teslimatYontemi.PaketTeslimEt(adres);
        }

    }
}
