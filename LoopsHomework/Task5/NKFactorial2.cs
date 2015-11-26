using System;
using System.Numerics;

namespace Task5
{
    class NKFactorial2
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorial1 = 1;
            BigInteger factorial2 = 1;

            if (k > 1 && k < n)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial1 *= i;
                }
                Console.WriteLine("n = {0}", factorial1);

                for (int j = 1; j <= k; j++)
                {
                    factorial2 *= j;
                }
                Console.WriteLine("k = {0}", factorial2);
            }

            else
            {
                Console.WriteLine("Invalid entry!");
            }

            BigInteger result = factorial1 * factorial2 / (factorial1 - factorial2);
            Console.WriteLine("n!*k! / (n-k)! = {0}", result);
        }
    }
}
