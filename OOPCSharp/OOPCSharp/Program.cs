using OOPCSharp.Models;

namespace OOPCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Hyundai", "i20", 2018);

            car1.DisplayInfo();

            Bike bike1 = new Bike("Hero", 2020, true);

            bike1.DisplayInfo();

            Vehicle vehicle1 = new Car("Hyudai","i10" ,2017);
            vehicle1.DisplayInfo();

            Vehicle vehicle2 = new Bike("JAWA", 2022, true);
            vehicle2.DisplayInfo();

            //Abstract olduktan sonra 

           // Vehicle vehicle3 = new Vehicle("JAWA", "2019"); // con not create intance of abstract class
           car1.StartEngine();
            car1.TurnOn();
            car1.TurnOff();

            bike1.StartEngine();
            // Exception fırlatır çünkü 1886 dan küçük bir değer verildi
            // Car car2 = new Car("Hyundai", "Elentra", 1790);


        }
    }
}
