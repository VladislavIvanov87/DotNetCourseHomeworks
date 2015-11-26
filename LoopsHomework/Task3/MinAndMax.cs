using System;

namespace Task3
{
    class MinAndMax
    {
        static void Main()
        {
            Console.Write("Choose how many numbers you will enter: ");
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("Enter numbers: ");
            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                
                if (current > max)
                {
                    max = current; 
                }
                if (current < min)
                {
                    min = current;
                }
            }
            Console.WriteLine("The max number is {0}, the min number is {1}", max, min);
        }
    }
}
