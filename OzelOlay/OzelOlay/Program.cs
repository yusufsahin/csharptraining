namespace OzelOlay
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici = new Kullanici();

            KullaniciOturumAbonesi abone= new KullaniciOturumAbonesi();

            kullanici.UserLoggedIn += abone.OturumAcilincaBilgiVer;

            // Kullanıcı oturum açıyor
            kullanici.OturumAc("Ali");

            Console.WriteLine("İşlem tamamlandı. Programdan çıkmak için bir tuşa basın.");
            Console.ReadKey();
        }
    }
}
