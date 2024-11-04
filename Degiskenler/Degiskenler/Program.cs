namespace Degiskenler
{
    public class Program
    {
        static void Main(string[] args)
        {
            // tam sayı değer int, long, short, byte, sbyte, uint, ulong, ushort türlerinde tanımlanabilir.
            int integerNumber = 100; // 32 bit
            long longNumber = 1009L; // 64 bit
            long longNumber2 = 9223372036854775807L;
            short shortNumber = 10; // 16 bit
            byte byteNumber = 255; // 8 bit
            Console.WriteLine(integerNumber);

            Console.WriteLine($"int: MinValue = {int.MinValue}, MaxValue = {int.MaxValue}");
            Console.WriteLine($"long: MinValue = {long.MinValue}, MaxValue = {long.MaxValue}");
            Console.WriteLine($"short: MinValue = {short.MinValue}, MaxValue = {short.MaxValue}");
            Console.WriteLine($"byte: MinValue = {byte.MinValue}, MaxValue = {byte.MaxValue}");
            Console.WriteLine($"uint: MinValue = {uint.MinValue}, MaxValue = {uint.MaxValue}");
            Console.WriteLine($"ulong: MinValue = {ulong.MinValue}, MaxValue = {ulong.MaxValue}");
            Console.WriteLine($"ushort: MinValue = {ushort.MinValue}, MaxValue = {ushort.MaxValue}");
            Console.WriteLine($"sbyte: MinValue = {sbyte.MinValue}, MaxValue = {sbyte.MaxValue}");
            long a = integerNumber;

            int b = (int)longNumber;
            int c = (int)longNumber2;

            Console.WriteLine(b);
            Console.WriteLine(c);

            // ondalıklı sayılar float, double, decimal türlerinde tanımlanabilir.

            float floatNumber = 10.5f; // 32 bit
            double doubleNumber = 29.99; // 64 bit
            decimal decimalNumber = 100.5m; // 128 bit

            Console.WriteLine($"float: MinValue = {float.MinValue}, MaxValue = {float.MaxValue}");
            Console.WriteLine($"double: MinValue = {double.MinValue}, MaxValue = {double.MaxValue}");
            Console.WriteLine($"decimal: MinValue = {decimal.MinValue}, MaxValue = {decimal.MaxValue}");

            Console.WriteLine(floatNumber);

            char character = 'A'; // 16 bit
            bool isTrue = true; // True veya False değer alabilir.

            Console.WriteLine(character);
            Console.WriteLine(isTrue);

            Point point = new Point();
            point.X = 10;
            point.Y = 20;
            Console.WriteLine($"Struct Point: X = {point.X}, Y = {point.Y}");

            Console.WriteLine(Days.Carsamba);

            ///Diziler / birden çok değer 
            ///
            int[] numbers = new int[5];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            Console.WriteLine(numbers[0]);
            int[] numbers2 = { 10, 20, 30, 40, 50 };
            Console.WriteLine(numbers2[0]);

            string[] names = { "Ali", "Veli", "Mehmet" };

            Console.WriteLine(names[0]);

            long[] longNumbers = { 70, 60000, 700000, 8000000 };
            Console.WriteLine(longNumbers[3]);


            //Null değer atama - nullable
            //int sayi = null; //Hata verir
            int? sayi = null;
            Console.WriteLine(sayi);
            sayi = 100;
            Console.WriteLine(sayi);


            //Implicitly Typed Local Variables

            var implicitlyNumber = 100;

            Console.WriteLine(implicitlyNumber);

            //implicitlyNumber = "Ali"; //Hata verir

            var implicitlyString = "Ali";
           // implicitlyString = 100; //Hata verir

            Console.WriteLine(implicitlyString);


            //Dynamic Type

            dynamic dynamicVariable = 100;
            Console.WriteLine(dynamicVariable);
            dynamicVariable = "Ali";
            Console.WriteLine(dynamicVariable);


            object obj = "This is an object";

            Console.WriteLine(obj);

            Employee employee= new Employee();
            employee.Id = 1;
            employee.Firstname = "John";
            employee.Lastname = "Doe";
            employee.Salary = 1500;
            employee.ShowInfos();
            Console.WriteLine(employee.CalculateTax());
            Console.WriteLine(employee.GetFullName());

        }
    }
}
