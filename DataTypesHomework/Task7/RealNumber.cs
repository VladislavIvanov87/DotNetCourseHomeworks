using System;

namespace Task7
{
    class RealNumber
    {
        static void Main()
        {
            Console.Write("Enter some floating-point number: ");
            double number = double.Parse(Console.ReadLine());
            int otherNumber = 3;

            double result = number / otherNumber;
            Console.WriteLine(result);
        }
    }
}
