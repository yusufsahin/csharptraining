
namespace Operatorler
{
    public class Program
    {
        static void Main(string[] args)
        {
            // aritmetik operatörler +,-,*,/,%

            int a = 10;
            int b = 5;
            
            int toplam = a + b;
            int fark = a - b;
            int carpim = a * b;
            int bolum = a / b;
            int mod = a % b;

            System.Console.WriteLine("Toplam: " + toplam);
            System.Console.WriteLine("Fark: " + fark);
            System.Console.WriteLine("Çarpım: " + carpim);
            System.Console.WriteLine("Bölüm: " + bolum);
            System.Console.WriteLine("Mod: " + mod);

            //Atama operatörleri =, +=, -=, *=, /=, %=
            int x = 5;
            Console.WriteLine(x); //5
            x += 3; // x = x + 3;
            Console.WriteLine(x); //8
            x -= 2; // x = x - 2;
            Console.WriteLine(x); //6
            x *= 4; // x = x * 4;
            Console.WriteLine(x); //24
            x /= 3; // x = x / 3;
            Console.WriteLine(x); //8
            x %= 2;
            Console.WriteLine(x); //0

            //Karşılaştırma operatörleri ==, !=, >, <, >=, <=

            int sayi1 = 10;
            int sayi2 = 15;

            bool esitMi = (sayi1 == sayi2);
            bool esitDegilMi = (sayi1 != sayi2);
            bool buyukMu = (sayi1 > sayi2);
            bool kucukMu = (sayi1 < sayi2);
            bool buyukEsitMi = (sayi1 >= sayi2);
            bool kucukEsitMi = (sayi1 <= sayi2);

            Console.WriteLine("Eşit mi: " + esitMi);
            Console.WriteLine("Eşit değil mi: " + esitDegilMi);
            Console.WriteLine("Büyük mü: " + buyukMu);
            Console.WriteLine("Küçük mü: " + kucukMu);
            Console.WriteLine("Büyük eşit mi: " + buyukEsitMi);
            Console.WriteLine("Küçük eşit mi: " + kucukEsitMi);

            /*
            Mantıksal işlemler yapmak için kullanılır. Sonuçları true veya false döner.
            &&: Mantıksal VE (Her iki ifade de true ise sonuç true olur.)
            ||: Mantıksal VEYA (İki ifadeden biri true ise sonuç true olur.)
            !: Mantıksal DEĞİL (İfadenin tersini alır.)
             
             */

            bool i = true;
            bool j = false;

            bool veSonuc = i && j;
            Console.WriteLine(veSonuc);
            bool veyaSonuc = i || j;
            Console.WriteLine(veyaSonuc);
            bool tersi = !veyaSonuc;
            Console.WriteLine(tersi);
        }
    }
}
