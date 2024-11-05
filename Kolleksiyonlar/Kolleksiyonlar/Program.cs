using Kolleksiyonlar.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Kolleksiyonlar
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<string> meyveler = new List<string> { "Elma","Armut","Muz"};

            meyveler.Add("Çilek");
            meyveler.Remove("Muz");

            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);
            }

            Dictionary<int, string> ogrenciler = new Dictionary<int, string>
            {
                { 101,"Ali"},
                { 102,"Veli"},
                { 103,"Ayşe"}
            };

            ogrenciler.Add(104, "Fatma");

            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }

            ogrenciler[101]= "Ahmet";// 101 numaralı öğrencinin adını değiştirme
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }

            ///FIFO Queue
            ///
            Queue<string> kuyruk = new Queue<string>();

            kuyruk.Enqueue("A");
            kuyruk.Enqueue("B");
            kuyruk.Enqueue("C");

            string ilkEleman = kuyruk.Dequeue();

            string sonrakiEleman = kuyruk.Peek();

            Console.WriteLine($"Çıkırılan ilk eleman : {ilkEleman}");
            Console.WriteLine($"Kuyruktaki sonraki eleman : {sonrakiEleman}");
            kuyruk.Dequeue();
            string  sonrakindenSonrakiEleman = kuyruk.Peek();
            Console.WriteLine($"Kuyruktaki sonrakinden sonraki eleman : {sonrakindenSonrakiEleman}");

            ///LIFO Stack
            ///
            Stack<int> yigin= new Stack<int>();

            yigin.Push(10);
            yigin.Push(20);
            yigin.Push(30);

            int enUsttekiEleman = yigin.Pop();
            int ustekiEleman = yigin.Peek();
            Console.WriteLine($"Çıkarılan eleman: {enUsttekiEleman}");
            Console.WriteLine($"En üstteki eleman: {ustekiEleman}");


            //Unique elemanlar
            HashSet<int> sayilar = new HashSet<int> { 1, 2, 3, 4, 5 };
            sayilar.Add(3);
            sayilar.Add(6);

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            //Sıralı Anahtar Değer Çiftleri

            SortedList<int, string> kitaplar = new SortedList<int, string>
            {
                { 3,"Kitap C"},
                { 1,"Kitap A"},
                { 2,"Kitap B"}
            };

            kitaplar.Add(4, "Kitap D");
            kitaplar.Add(0, "Kitap -");
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }

            //Observable Collection

            ObservableCollection<string> isimler = new ObservableCollection<string> { "Ali", "Veli", "Ayşe" };
            isimler.CollectionChanged += Isimler_CollectionChanged;
            isimler.Add("Ahmet");
            isimler.Add("Elif");


            List<Employee> employees = new List<Employee>
            {
                new Employee(1,"John","Doe",5000),
                new Employee(2,"Jane","Doe",6000),
                new Employee(3,"Sue","Doe",7000),
                new Employee(4,"Tom","Doe",8000)
            };

            employees.Add(new Employee(5, "Alice", "Doe", 9000));

            Console.WriteLine("Ücret 6000 in üzerinde olanlar");

            List<Employee> filteredEmployeeList= employees.Where(e => e.Salary > 6000).ToList();

            foreach (var employee in filteredEmployeeList)
            {
                Console.WriteLine(employee.Id+"-"+ employee.Firtname+" "+employee.Lastname+ " "+employee.Salary);
            }

        }

        private static void Isimler_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Koleksiyon değişti!");
        }
    }
}
