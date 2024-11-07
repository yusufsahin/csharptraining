namespace ConsumeEvent
{
    public class DosyaIndirmeAbonesi
    {

        public void IndirmeBilgisi(object sender, DosyaIndirildiEventArg e)
        {
            Console.WriteLine($"Abone: {e.DosyaAdi} başarıyla indirildi.");
        }
    }
}
