
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Models
{
    public class Intern:Employee
    {
        public string School { get; set; }

        public Intern(string name, int age,string position ,string school) : base(name, age,position)
        {
            School = school;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"School: {School}");
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is doing internship tasks.");
        }

        public override void TakeBreak()
        {
            Console.WriteLine($"{Name} is taking a lunch break at the cafeteria.");

        }
    }
}
