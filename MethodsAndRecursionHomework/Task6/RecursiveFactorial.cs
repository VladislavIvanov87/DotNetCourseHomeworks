using System;
using System.Numerics;

namespace Task6
{
    class RecursiveFactorial
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = Factorial(n);
            Console.WriteLine("{0}! = {1}", n, factorial);
        }

        private static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
