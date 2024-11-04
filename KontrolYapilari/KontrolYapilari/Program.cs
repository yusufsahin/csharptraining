namespace KontrolYapilari
{
    public class Program
    {
        static void Main(string[] args)
        {

            ///Kontrol Yapıları

            //if - else if - else yapısı
            Console.WriteLine("Lütfen yaşınızı giriniz: ");
            string yasGirdisi=Console.ReadLine();

            int yas = int.Parse(yasGirdisi);

            if (yas < 18)
            {
                Console.WriteLine("Reşit değilsiniz.");
            }else if(yas>= 18 && yas < 21)
            {
                Console.WriteLine("Reşitsiniz.Ama ehliyet alamazsınız.");
            }
            else
            {
                Console.WriteLine("Reşitsiniz.Ehliyet alabilirsiniz.");
            }


            //switch-case yapısı

            Console.WriteLine("Bir gün numarası giriniz (1-7) :  ");

            string gunGirdisi=Console.ReadLine();
            int gun = int.Parse(gunGirdisi);

            switch (gun) {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Geçersiz gün numarası girdiniz.");
                    break;
            }

            ///Döngüler
            //for döngüsü
            for (int i = 0; i <= 10; i=i+2)
            {
                Console.WriteLine(i);
            }

            //while döngüsü
            // sayı azaltalım

            Console.WriteLine("Bir sayı giriniz: ");
            string sayiGirdisi = Console.ReadLine();
            int sayi = int.Parse(sayiGirdisi);

            while (sayi > 0)
            {
                Console.WriteLine(sayi);
                sayi--;
                //sayi=sayi-1;
            }
            Console.WriteLine("Sayi sıfır oldu.");

            //do-while döngüsü
            /*
            string giris;

            do {
                Console.WriteLine("Bir şeyler yazınız (Çıkmak için 'exit' yazınız): ");
                giris = Console.ReadLine();
                Console.WriteLine("Girdiğiniz şey: " + giris);
            } while (giris != "exit");

            Console.WriteLine("Programdan çıkıldı.");
            
             */
            string giris;

            do
            {
                Console.WriteLine("Bir şeyler yazınız (Çıkmak için 'exit' yazınız): ");
                giris = Console.ReadLine();
                Console.WriteLine("Girdiğiniz şey: " + giris);

                if (giris == "exit")
                {
                    break;
                }

                if (giris == "continue")
                {
                    continue;
                }
            } while (true);

            Console.WriteLine("Programdan çıkıldı.");

            //foreach döngüsü

            string[] isimler = { "Ali", "Veli", "Ayşe", "Fatma" };

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int s in sayilar)
            {
                Console.WriteLine(s);
            }

        }
    }
}
