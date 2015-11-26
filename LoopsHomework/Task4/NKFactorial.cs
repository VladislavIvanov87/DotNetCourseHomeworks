using System;
using System.Numerics;

namespace Task4
{
    class NKFactorial
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            if (k > 1 && k < n)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    result *= i;
                }
                Console.WriteLine("n!/k! = " + result);
            }
            
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}
