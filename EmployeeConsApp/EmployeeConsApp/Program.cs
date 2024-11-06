using System.Data.SqlClient;

namespace EmployeeConsApp
{
    public class Program
    {
        private static string connectionString = @"Data Source=localhost;User ID=sa;Password=Passw0rd@2024;Connect Timeout=30;Initial Catalog=EmployeeData";


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. List Employees");
                Console.WriteLine("5. View Employee By Id");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        UpdateEmployee();
                        break;
                    case 3:
                        DeleteEmployee();
                        break;
                    case 4:
                        ListEmployees();
                        break;
                    case 5:
                        ViewEmployeeById();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private static void ViewEmployeeById()
        {
            Console.WriteLine("Enter Employee Id to view");
            int id = int.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString)) { 
            
                string query = "SELECT * FROM Employees WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Console.WriteLine($"Id: {reader["Id"]}");
                    Console.WriteLine($"Firstname: {reader["Firstname"]}");
                    Console.WriteLine($"Lastname: {reader["Lastname"]}");
                    Console.WriteLine($"Age: {reader["Age"]}");
                }
                else
                {
                    Console.WriteLine("Employee not found");
                }
            }
        }

        private static void ListEmployees()
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) { 
                string query = "SELECT * FROM Employees";

                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("\nId Firstname Lastname Age");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Id"]}\t{reader["Firstname"]}\t{reader["Lastname"]}\t{reader["Age"]}");
                }
            }
        }

        private static void DeleteEmployee()
        {
            Console.WriteLine("Enter Employee ID to delete");
            int id = int.Parse(Console.ReadLine());
            using (SqlConnection conn=new SqlConnection(connectionString))
            {

                string query = "DELETE FROM Employees WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                int rowAffected = cmd.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    Console.WriteLine("Employee deleted successfully");
                }
                else
                {
                    Console.WriteLine("Employee not found");
                }

            }
        }

        private static void UpdateEmployee()
        {
            Console.WriteLine("Enter Employee ID to update");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Employee Firstname: ");
            string firstname = Console.ReadLine();

            Console.Write("Enter New Employee Lastname: ");
            string lastname = Console.ReadLine();

            Console.Write("Enter New Employee Age: ");
            int age = int.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employees SET Firstname=@Firstname, Lastname=@Lastname, Age=@Age WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Firstname", firstname);
                cmd.Parameters.AddWithValue("@Lastname", lastname);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                int rowAffected=cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    Console.WriteLine("Employee updated successfully");
                }
                else
                {
                    Console.WriteLine("Employee not found");
                }


            }

        }

        private static void AddEmployee()
        {
            Console.Write("Enter Employee Firstname: ");

            string firstname = Console.ReadLine();
            Console.Write("Enter Employee Lastname: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter Employee Age: ");
            int age = int.Parse(Console.ReadLine());

            using(SqlConnection conn= new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Employees (Firstname, Lastname, Age) VALUES (@Firstname, @Lastname, @Age)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Firstname", firstname);
                    cmd.Parameters.AddWithValue("@Lastname", lastname);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Employee added successfully");
                }
            }
        }
    }
}
