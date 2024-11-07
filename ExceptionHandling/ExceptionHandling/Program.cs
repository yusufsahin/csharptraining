using System.Data.SqlClient;

namespace ExceptionHandling
{
    public class Program
    {

        private static string connectionString = @"Data Source=localhost;User ID=sa;Password=Passw0rd@2024;Connect Timeout=30;Initial Catalog=EmployeeData";

        static void Main(string[] args)
        {

            try
            {
                int sayi = 10;
                int sonuc = sayi / 0;

               // int sonuc = sayi / 2;
                Console.WriteLine(sonuc);
            }
            catch (DivideByZeroException ex) { 

                Console.WriteLine("Sıfıra bölme hatasi : "+ex.Message);
            
            }finally
            {
                Console.WriteLine("işlem tamamlandı");
            }
            //Özel durumlar
            try
            {
                int[] sayilar = new int[] { 1, 2, 3, 4, 5 };
                Console.WriteLine(sayilar[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Dizi sınırlarını aştınız : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu : " + ex.Message);
            }

           // SayiKontrol(-1);


            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                Console.WriteLine("Bağlantı açıldı");

                using (SqlCommand cmd = new SqlCommand("Select * From Employees", conn))
                {
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["FirstName"].ToString() + " " + dr["LastName"].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Veritabanı hatası : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu : " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("Bağlantı kapatıldı");
                }
            }


            YasKontrol(16);

        }

        private static void YasKontrol(int yas)
        {
          if(yas < 18)
            {
                throw new GecersizYasException("Yaşınız 18'den küçük olamaz");
            }
        }

        public static void SayiKontrol(int sayi)
        {
            if (sayi < 0)
            {
                throw new ArgumentException("Sayı sıfırdan küçük olamaz");
            }
        }
    }
}
