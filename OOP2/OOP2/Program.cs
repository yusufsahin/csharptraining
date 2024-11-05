using OOP2.Models;

namespace OOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Supervisor supervisor = new Supervisor("John Doe", 30,"IT" ,"Developer");
      
            supervisor.DisplayInfo();
            Console.WriteLine(supervisor.ToString());
            Manager manager = new Manager("Alice Johnson", 40,"HR", 10);
            manager.DisplayInfo();
            Intern intern = new Intern("Tom White", 21,"HR", "University of XYZ");
            intern.DisplayInfo();
            Employee tester = new Supervisor("Jane Doe", 30, "IT", "Tester");
            List<Employee> list = new List<Employee>();
            list.Add(supervisor);
            list.Add(manager);
            list.Add(intern);
            list.Add(tester);

            foreach (var emp in list)
            {
                emp.Work();
            }

            manager.CalculateSalary();

            supervisor.CalculateSalary();
           // tester.CalculateSalary(); //HATA Verir

            //Employee emp2 = new Employee("Bob Smith", 40, "HR", 15);
        }
    }
}
