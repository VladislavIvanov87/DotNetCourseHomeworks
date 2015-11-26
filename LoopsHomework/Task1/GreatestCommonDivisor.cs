using System;

namespace Task1
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("The greatest common divisor of {0} and {1} is: ",
                firstNumber, secondNumber);

            if (firstNumber < secondNumber)
            {
                firstNumber = firstNumber + secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber = firstNumber - secondNumber;
            }

            int divisor = firstNumber % secondNumber;

            while (divisor != 0)
            {
                firstNumber = secondNumber;
                secondNumber = divisor;
                divisor = firstNumber % secondNumber;
            }

            Console.WriteLine("{0}", secondNumber);
        }
    }
}
