using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Sinif
    {
        public int SinifID{ get; set; }
        public string Ders { get; set; }

       public int OgrenciID { get; set; }
        public Sinif()
        {

        }

        public Sinif(int sinifID, string ders, int ogrenciID)
        {
            SinifID = sinifID;
            Ders = ders;
            OgrenciID = ogrenciID;
        }
    }
}
