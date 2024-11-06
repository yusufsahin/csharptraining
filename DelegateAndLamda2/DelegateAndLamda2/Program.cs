namespace DelegateAndLamda2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            Func<int, int, int> subtract = (a, b) => a - b;
            Func<int, int, int> multiply = (a, b) => a * b;
            Func<int, int, int> divide = (a, b) => {
                if (b == 0)
                {
                    Console.WriteLine("Hata: Sıfıra bölme işlemi geçersiz.");
                    return 0;
                }
                return a / b;
            };


            Console.WriteLine("Bir işlem seçin:");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            string choice = Console.ReadLine();

           Console.WriteLine("İlk sayıyı girin:");
           int a = int.Parse(Console.ReadLine());
           Console.WriteLine("İkinci sayıyı girin:");
           int b = int.Parse(Console.ReadLine());

            int result = choice switch
            {
                "1" => add(a, b),
                "2" => subtract(a, b),
                "3" => multiply(a, b),
                "4" => divide(a, b),
                _ => throw new InvalidOperationException("Geçersiz seçim.")
            };

            Console.WriteLine($"Sonuç: {result}");
        }
    }
}
