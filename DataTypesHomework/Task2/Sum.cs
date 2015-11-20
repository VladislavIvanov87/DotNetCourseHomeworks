using System;

namespace Task2
{
    class Sum
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            Console.WriteLine("The sum is " + sum);
        }
    }
}
