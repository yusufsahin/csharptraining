namespace OzelOlay
{
    public class KullaniciOturumAbonesi
    {
        
        public void OturumAcilincaBilgiVer(object sender, UserLoggedInEventArgs e)
        {
            Console.WriteLine($"Abone: {e.KullaniciAdi} isimli kullanıcı oturum açtı.");
        }
    }
}