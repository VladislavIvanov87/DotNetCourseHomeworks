using System;

namespace Task1
{
    class SumEven
    {
        static void Main()
        {
            Console.Write("Enter a number which will be the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine("Fill the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine("The sum of all even elements is " + sum);
        }
    }
}
