using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public float Salary { get; set; }

        /*
        private int id;
        private string firstname;
        private string lastname;
        private float salary;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Firstname { 
            get { return firstname; } 
            set { firstname = value; } 
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        */
        public Employee()
        {

        }

        public Employee(int id, string firstname, string lastname, float salary)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Salary = salary;
        }

        public void ShowInfos()
        {
            Console.WriteLine($"Id: {Id}, Firstname: {Firstname}, Lastname: {Lastname}, Salary: {Salary}");
        }

        public float CalculateTax()
        {
            return Salary * 0.25f;
        }

        public string GetFullName()
        {
            return Firstname + " " + Lastname;
        }
    }
}
