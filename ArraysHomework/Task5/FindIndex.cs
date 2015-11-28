using System;

namespace Task4
{
    class FindIndex
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

            Console.Write("Enter a number to find its index: ");
            int number = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    Console.WriteLine("The number is on index {0}", i);
                    isFound = true;
                    break;
                }
            }
        }
    }
}
