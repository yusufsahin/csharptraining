using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp.Models
{
    public class Bike : Vehicle
    {
        public bool HasCarrirer { get; set; }

        public Bike(string brand, int year, bool hasCarrirer) : base(brand, year)
        {
            HasCarrirer = hasCarrirer;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"HasCarrirer: {HasCarrirer}");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine is started");
        }
    }
}
