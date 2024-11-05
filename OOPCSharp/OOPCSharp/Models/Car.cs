using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp.Models
{
    public class Car : Vehicle,IConditioner
    {


        public string Model { get; set; }

        public Car(string brand, string model, int year):base(brand, year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

       
        public void DisplayInfo()
        {
           // base.DisplayInfo();
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }

        public void TurnOn()
        {
            Console.WriteLine("Conditioner is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Conditioner is off");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Car engine is started");
        }
    }
}
