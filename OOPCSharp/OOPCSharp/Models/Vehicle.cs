using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp.Models
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        private int year;

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1886)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException("Year must be greater than 1886");
                }
            }
        }

       

        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }
        public abstract void StartEngine();
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Year: {Year}");
        }
    }
}
