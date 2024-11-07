namespace ConsumeEvent
{
    public class Program
    {
        static void Main(string[] args)
        {
            DosyaIndirme dosyaIndirme = new DosyaIndirme();
            DosyaIndirmeAbonesi abone = new DosyaIndirmeAbonesi();

            dosyaIndirme.DosyaIndirildi += abone.IndirmeBilgisi;

            dosyaIndirme.IndirmeBaslat("example.txt");

            Console.WriteLine("İşlem tamamlandı. Programdan çıkmak için bir tuşa basın.");
            Console.ReadKey();
        }
    }
}
