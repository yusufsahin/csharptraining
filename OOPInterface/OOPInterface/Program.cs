namespace OOPInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            ITeslimat standartTeslimat = new StandartTeslimat();
            ITeslimat hizliTeslimat = new HizliTeslimat();
            ITeslimat uluslararasiTeslimat = new UluslararasiTeslimat();

            Siparis siparis1 = new Siparis(standartTeslimat);
            siparis1.SiparisVer("İstanbul,Türkiye");

            Siparis siparis2 = new Siparis(hizliTeslimat);
            siparis2.SiparisVer("Ankara,Türkiye");

            Siparis siparis3 = new Siparis(uluslararasiTeslimat);
            siparis3.SiparisVer("New York,ABD");
        }
    }
}
