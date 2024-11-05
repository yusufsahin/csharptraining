using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Models
{
    public class Supervisor : Employee,IPayable
    {
        public string Department { get; set; }


        public Supervisor(string name, int age,string position, string department) : base(name, age,position)
        {
            Department = department;
        }
        public override void TakeBreak()
        {
            Console.WriteLine($"{Name} is taking a have a coffee break the cafeteria with leads.");
            
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing the team and working on the project.");
        }

        public void CalculateSalary()
        {
            Console.WriteLine($"{Name}'s salary is calculated based on annual performance.");

        }
    }
}
