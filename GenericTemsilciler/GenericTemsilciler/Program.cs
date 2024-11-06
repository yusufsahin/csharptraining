using System.Reflection;

namespace GenericTemsilciler
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Action Generic Temsilcisi");

            //return tipi void olan ve parametre almayan bir metot temsilcisi tanımlanıyor.
            //return değeri olmayan metotları temsil eder.

            Action action = () => Console.WriteLine("Merhaba");
            //Paremeterili
           // Console.WriteLine(action);

            Action<string> mesajGoster = (string s) => Console.WriteLine(s);

            //Action temsilcisi ile metot çağrılıyor.

            mesajGoster("Merhaba");


            Console.WriteLine("Func Generic Temsilcisi");
            //Func temsilcisi geriye bir değer dönen metotları temsil eder.son parametre dönüş değeridir
            Func<int,int,decimal> kdvHesapla = (int fiyat, int kdvOran) => fiyat + (fiyat * kdvOran / 100);
            Console.WriteLine("Kdv li fiyat "+ kdvHesapla(28, 20));


            Console.WriteLine("Predicate Generic Temsilcisi");
            //Predicate temsilcisi geriye bool dönen metotları temsil eder.

            Predicate<int> ciftMi = (int sayi) => sayi % 2 == 0;

            Console.WriteLine(ciftMi(5));
            Console.WriteLine(ciftMi(6));
        }
    }
}
