using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaceInheritance
{
    public class DosyaIslemleri : IDosya
    {
        public void Oku()
        {
            Console.WriteLine("Dosya okunuyor...");

        }
        
        public void Yaz(string icerik)
        {
            Console.WriteLine($"Dosyaya yazılıyor: {icerik}");
        }
        public void Sil()
        {
            Console.WriteLine("Dosya siliniyor...");
        }    
    }
}
