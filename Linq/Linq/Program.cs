namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Temel Operatörler 

           
            var sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //1. Where -> filtreleme işlemi yapar   
            var ciftSayilar = sayilar.Where(s => s % 2 == 0);

            foreach (var sayi in ciftSayilar)
            {
                Console.WriteLine(sayi);
            }

            //2. Select -> Seçme işlemi yapar ve dönüşüm işlemi yapar 

            var kareleri = sayilar.Select(s => s * s);

            foreach (var sayi in kareleri)
            {
                Console.WriteLine(sayi);
            }
             var isimler = new string[] { "Ali", "Veli", "Deli", "Mehmet", "Ayşe", "Fatma" };

            var buyukHarfliIsimler = isimler.Select(s => s.ToUpper());

            foreach (var isim in buyukHarfliIsimler)
            {
                Console.WriteLine(isim);
            }
            //3. OrderBy -> Sıralama işlemi yapar

            var sayilar2 = new List<int> { 5, 3, 9, 1,27,89 };

            var siraliSayilar = sayilar2.OrderBy(s => s);

            foreach (var sayi in siraliSayilar)
            {
                Console.WriteLine(sayi);
            }

            //OrderByDescending -> Sıralama işlemi yapar
            var sayilar3 = new List<int> { 5, 3, 9, 1, 27, 89 };

            var terstenSiraliSayilar = sayilar3.OrderByDescending(s => s);
            foreach (var sayi in terstenSiraliSayilar)
            {
                Console.WriteLine(sayi);
            }
            //GroupBy -> Gruplama işlemi yapar, belirli bir anahtara göre gruplar


            var ogrenciler= new List<Ogrenci>
            {
                new Ogrenci{OgrenciID=1,Ad="Ali",Soyad="Yılmaz",Yas=20,Sehir="Ankara",Sinif=1},
                new Ogrenci{OgrenciID=2,Ad="Veli",Soyad="Kara",Yas=21,Sehir="İstanbul",Sinif=2},
                new Ogrenci{OgrenciID=3,Ad="Deli",Soyad="Kara",Yas=22,Sehir="Ankara",Sinif=1},
                new Ogrenci{OgrenciID=4,Ad="Mehmet",Soyad="Yılmaz",Yas=23,Sehir="İstanbul",Sinif=2},
                new Ogrenci{OgrenciID=5,Ad="Ayşe",Soyad="Kara",Yas=24,Sehir="Ankara",Sinif=1},
                new Ogrenci{OgrenciID=6,Ad="Fatma",Soyad="Yılmaz",Yas=25,Sehir="İstanbul",Sinif=2}
            };

            var gruplar = ogrenciler.GroupBy(o => o.Sehir);

            foreach (var item in gruplar)
            {
                Console.WriteLine(item.Key);
            }

            //Join -> İki tabloyu birleştirme işlemi yapar

            var siniflar = new List<Sinif>
            {
                new Sinif{SinifID=1,Ders="Matematik",OgrenciID=1},
                new Sinif{SinifID=2,Ders="Fizik",OgrenciID=2},
                new Sinif{SinifID=3,Ders="Kimya",OgrenciID=3},
                new Sinif{SinifID=4,Ders="Biyoloji",OgrenciID=4},
                new Sinif{SinifID=5,Ders="Edebiyat",OgrenciID=5},
                new Sinif{SinifID=6,Ders="Tarih",OgrenciID=6}
            };

            var sonuc = ogrenciler.Join(siniflar,
                o => o.OgrenciID,
                s => s.OgrenciID,
                (o, s) => new
                {
                    Ad = o.Ad,
                    Soyad = o.Soyad,
                    Ders = s.Ders
                });

            foreach (var item in sonuc)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Ders);
            }


            //Deferred Execution (Ertelenmiş Çalıştırma): ToList(), ToArray() gibi yöntemler kullanılana kadar sorgu yürütülmez.

            var sayilar4 = new List<int> { 1,2,3,4,5,6 };

            var tekSayilar = sayilar4.Where(s => s % 2 == 1);

            Console.WriteLine(tekSayilar.Count()); //Burada sorgu yürütülür


            var urunler = new List<Urun>
            {
                new Urun{Ad="Kalem",Kategori="Kırtasiye",StoktaVar=true},
                new Urun{Ad="Defter",Kategori="Kırtasiye",StoktaVar=false},
                new Urun{Ad="Bisiklet",Kategori="Spor",StoktaVar=true},
                new Urun{Ad="Bilgisayar",Kategori="Elektronik",StoktaVar=false},
                new Urun { Ad = "Telefon", Kategori = "Elektronik", StoktaVar = true },
                new Urun { Ad = "Televizyon", Kategori = "Elektronik", StoktaVar = false },
                new Urun { Ad = "Kitap", Kategori = "Kırtasiye", StoktaVar = true }
            };

            var kirtasiyeUrunleri = urunler.Where(u => u.Kategori == "Kırtasiye");
            Console.WriteLine("Kırtasiye Ürünleri:");
            foreach (var item in kirtasiyeUrunleri)
            {
                Console.WriteLine(item.Ad);
            }   

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Stokta olan ürünler:");
            var stoktaOlanUrunler = urunler.Where(u => u.StoktaVar == true).GroupBy(u=>u.Kategori);

            foreach (var grup in stoktaOlanUrunler)
            {
                Console.WriteLine($"{grup.Key}:");
                foreach (var urun in grup)
                {
                    Console.WriteLine($" - {urun.Ad}");
                }
            }
            
                
            
        }
    }
}
