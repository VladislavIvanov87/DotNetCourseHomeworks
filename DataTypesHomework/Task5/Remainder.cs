using System;

namespace Task5
{
    class Remainder
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber % secondNumber);
        }
    }
}
