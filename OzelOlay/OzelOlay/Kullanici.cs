namespace OzelOlay
{
    public class Kullanici
    {
        public event EventHandler<UserLoggedInEventArgs> UserLoggedIn;
        public void OturumAc(string kullaniciAdi)
        {
           Console.WriteLine($"{kullaniciAdi} oturum açtıyor...");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine($"{kullaniciAdi}  başarıyla oturum açtı.");

            UserLoggedIn?.Invoke(this, new UserLoggedInEventArgs{KullaniciAdi=kullaniciAdi});
        }
    }
}