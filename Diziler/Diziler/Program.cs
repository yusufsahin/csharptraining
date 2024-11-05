using System;

namespace Diziler
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Dizi elemanları");

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            int toplam = 0;

            foreach (var sayi in sayilar)
            {


                toplam += sayi * sayi;
            }

            Console.WriteLine("Toplam: " + toplam);

            int[,] matris = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Matris elemanları");

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();

            }


            Console.WriteLine("Düzensiz dizi elemanları");
            int[][] düzensizDizi = new int[3][];
           
            düzensizDizi[0] = new int[] { 1, 2, 3 };
            düzensizDizi[1] = new int[] { 4, 5 };
            düzensizDizi[2] = new int[] { 6, 7, 8, 9 };

            for(int i = 0; i < düzensizDizi.Length; i++)
            {
                for (int j = 0; j < düzensizDizi[i].Length; j++)
                {
                    Console.Write(düzensizDizi[i][j] + " ");
                }
                Console.WriteLine();
            }


            //Array sınıfı metotları

            int[] sayilar2 = { 5,6,3,1,0,7,9,2,4,8 };

            Array.Sort(sayilar2); ///Sıralama işlemi

            Console.WriteLine("Sıralanmış dizi elemanları");
            foreach (var sayi in sayilar2)
            {
                Console.WriteLine(sayi);
            }

            Array.Reverse(sayilar2); //Diziyi tersine çevirme işlemi

            foreach (var sayi in sayilar2)
            {
                Console.WriteLine(sayi);
            }

            //Array.Reverse(sayilar2); //Diziyi tekrar tersine çevirme işlemi
            int index = Array.IndexOf(sayilar2, 7); //Dizide 7 elemanının indexini bulma

            if(index != -1)
            {
                Console.WriteLine("Aranan elemanın indexi: " + index);
            }
            else
            {
                Console.WriteLine("Aranan eleman dizide bulunamadı");
            }

            int[] orijinalDizi =  { 10, 20, 30, 40, 50 };

            int[] kopyaDizi = new int[orijinalDizi.Length];

            Array.Copy(orijinalDizi, kopyaDizi, orijinalDizi.Length); //Diziyi kopyalama işlemi

            foreach (var sayi in kopyaDizi)
            {
                Console.WriteLine(sayi);
            }

            int[] klonDizi = (int[])orijinalDizi.Clone();

            Console.WriteLine("Klonlanmış dizi (Array.Clone):");
            foreach (var sayi in klonDizi)
            {
                Console.WriteLine(sayi);
            }


            int aranan = 50;

            int idx= Array.BinarySearch(klonDizi, aranan);

            if (idx >= 0) {
                Console.WriteLine($"{aranan} sayısı {idx}. indekste bulundu.");
            }
            else
            {
                Console.WriteLine($"{aranan} sayısı dizide bulunamadı.");
            }

            int[] filtrenecekDizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] tekSayilar= Array.FindAll(filtrenecekDizi,sayi=>sayi%2!=0);

            Console.WriteLine("Tek Sayilar");

            foreach(var t in tekSayilar) { 
                Console.WriteLine(t); 
            }

            int buyukSayi = Array.Find(filtrenecekDizi, sayi => sayi > 5);

            Console.WriteLine($"İlk 5'ten büyük sayı: {buyukSayi}");
        }
    }
}
