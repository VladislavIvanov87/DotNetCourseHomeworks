using System;

namespace Task4
{
    class EvenOrOdd
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintEvenOrOdd(number);
        }

        private static void PrintEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
