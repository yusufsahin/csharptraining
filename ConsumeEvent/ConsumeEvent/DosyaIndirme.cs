namespace ConsumeEvent
{
    public class DosyaIndirme
    {
        public event EventHandler<DosyaIndirildiEventArg> DosyaIndirildi;

        public void IndirmeBaslat(string dosyaAdi)
        {
            Console.WriteLine($"{dosyaAdi} indiriliyor...");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine($"{dosyaAdi} indirildi.");

            DosyaIndirildi?.Invoke(this, new DosyaIndirildiEventArg { DosyaAdi = dosyaAdi });
        }
    }
}
