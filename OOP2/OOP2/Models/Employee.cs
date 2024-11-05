using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP2.Models
{
    public abstract class Employee
    {
        private string _name;
        private int _age;
        private string _position;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    throw new ArgumentException("Name cannot be null or empty.");
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                    _age = value;
                else
                    throw new ArgumentException("Age must be greater than 0.");


            }
        }
        public string Position
        {
            get { return _position; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _position = value;
                else
                    throw new ArgumentException("Position cannot be null or empty.");
            }
        }

        public Employee(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;

        }

        public Employee() { }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Position: {Position}";
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Position: {Position}");
        }

        public abstract void Work();
        public abstract void TakeBreak();
       
    }
}
