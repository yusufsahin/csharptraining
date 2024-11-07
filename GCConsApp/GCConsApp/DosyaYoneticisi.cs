namespace GCConsApp
{
    public class DosyaYoneticisi : IDisposable
    {
        private bool disposed = false;
        public void DosyaAc()
        {
            Console.WriteLine("Dosya açıldı.");
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Yönettiğimiz kaynakları serbest bırak
                    Console.WriteLine("Yönetilen kaynaklar serbest bırakıldı.");
                }
                disposed = true;
            }
        }

        ~DosyaYoneticisi()
        {
            Dispose(false);
            Console.WriteLine("DosyaYoneticisi finalizer çağrıldı.");
        }
    }
}
