namespace OOPInterfaceInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDosya dosya = new DosyaIslemleri();

            dosya.Oku();
            dosya.Yaz("Merhaba Dünya");
            dosya.Sil();

            IAg ag = new AgIslemleri();

            ag.Oku();
            ag.Yaz("Merhaba Dünya");
            ag.Sil();
        }
    }
}
