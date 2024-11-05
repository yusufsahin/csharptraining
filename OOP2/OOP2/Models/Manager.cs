using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Models
{
    public class Manager : Employee,IPayable
    {
        public int TeamSize { get; set; }

        public Manager(string name, int age, string position, int teamSize) : base(name, age, position)
        {
            TeamSize = teamSize;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }

        public override void TakeBreak()
        {
            Console.WriteLine($"{Name} is taking a short break from meetings.");
        }

        public void CalculateSalary()
        {
            Console.WriteLine($"{Name}'s salary is calculated based on annual performance.");

        }
    }
}
