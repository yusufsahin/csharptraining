namespace DegerReferans
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x;

            y=10;
            Console.WriteLine("x : "+x);
            Console.WriteLine("y : "+y);

            Sample obj1 = new Sample
            {
                Value = 5
            };

            Sample obj2 = obj1;
            obj2.Value = 10;
            Console.WriteLine("obj1.Value : " + obj1.Value);
            Console.WriteLine("obj2.Value : " + obj2.Value);

            int myNumber = 5;

            ChangeValue(ref myNumber);

            Console.WriteLine("myNumber : " + myNumber);


            int myNumber1;
            int myNumber2;

            GetValues(out myNumber1, out myNumber2);
            Console.WriteLine(myNumber1);
            Console.WriteLine(myNumber2);
        }
        //Pass by Value
        /* static void ChangeValue(int number)
        {
            number = 10;
        }*/

        //Pass by Reference
        static void ChangeValue(ref int number)
        {
            number = 10;
        }
        //Out
        static void GetValues(out int number1, out int number2)
        {
            number1 = 30;
            number2 = 40;
        }
    }   
}
