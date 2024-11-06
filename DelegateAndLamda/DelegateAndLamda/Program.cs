namespace DelegateAndLamda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            MathOperation operation;

            Console.WriteLine("Enter the operation you want to perform: ");

            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    operation = calculator.Add;
                    break;
                case 2:
                    operation = calculator.Subtract;
                    break;
                case 3:
                    operation = calculator.Multiply;
                    break;
                case 4:
                    operation = calculator.Divide;
                    break;
                default:
                    operation = null;
                    break;
            }

            Console.WriteLine("Enter the first number: ");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            int result = operation(a, b);

            Console.WriteLine("The result is: " + result);
        }
    }
}
