using System;

namespace Task5
{
    class SymmetricNumbers
    {
        static void Main()
        {
            for (int i = 10; i <= 999; i++)
            {
                PrintSymmetricNumbers(i);
            }
        }

        private static void PrintSymmetricNumbers(int number)
        {
            if (number < 10 && number >= 1000)
            {
                Console.WriteLine("The number is out of range");
            }

            if (number < 100 && number % 11 == 0)
            {
                Console.WriteLine(number);
            }

            if (number > 100)
            {
                int firstNumber = number / 100;
                int lastNumber = number % 10;

                if (firstNumber == lastNumber)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
