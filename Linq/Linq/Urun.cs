namespace Linq
{
    public class Urun
    {
        public string Ad { get; set; }
        public string Kategori { get; set; }
        public bool StoktaVar { get; set; }

        public Urun()
        {
            
        }

        public Urun(string ad, string kategori, bool stoktaVar)
        {
            Ad = ad;
            Kategori = kategori;
            StoktaVar = stoktaVar;
        }
    }
}
