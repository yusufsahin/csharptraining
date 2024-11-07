namespace GCConsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
           using(var yonetici = new DosyaYoneticisi())
            {
                yonetici.DosyaAc();
            }

            Console.WriteLine("Dispose metodu çağrıldı ve kaynak serbest bırakıldı.");
            Console.ReadKey();
        }
    }
}
