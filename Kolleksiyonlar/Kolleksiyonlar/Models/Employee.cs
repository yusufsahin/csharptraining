using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolleksiyonlar.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firtname { get; set; }
        public string Lastname { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string firtname, string lastname, double salary)
        {
            Id = id;
            Firtname = firtname;
            Lastname = lastname;
            Salary = salary;
        }
    }
}
