using System;

namespace Task2
{
    class FibonacciArray
    {
        static void Main()
        {
            Console.Write("Enter a number which will be the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            int previous = -1;
            int next = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = previous + next;
                previous = next;
                next = array[i];
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
