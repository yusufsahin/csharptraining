using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaceInheritance
{
    public class AgIslemleri : IAg
    {
        public void Oku()
        {
            Console.WriteLine("Ağdan okunuyor...");
        }

        public void Yaz(string icerik)
        {
            Console.WriteLine($"Ağdan yazılıyor: {icerik}");
        }

        public void Sil()
        {
            Console.WriteLine("Ağdan siliniyor...");
        }
    }
}
