using System;

namespace Task3
{
    class Multiplication
    {
        static void Main()
        {
            Random generator = new Random();

            int a = generator.Next(1, 101);
            int b = generator.Next(1, 101);
            int c = generator.Next(1, 101);

            Console.WriteLine("The result is " + PrintMultiplication(a, b, c));            
        }

        private static int PrintMultiplication(int a, int b, int c)
        {
            int result = a * b * c;
            return result;
        }
    }
}
