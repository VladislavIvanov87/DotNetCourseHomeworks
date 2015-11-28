using System;

namespace Classwork2
{
    class ReverseArray
    {
        static void Main()
        {
            int[] firstArray = new int[] { 3, 5, 9, 12, 17, 21 };
            int[] reversedArray = new int[firstArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                reversedArray[firstArray.Length - i - 1] = firstArray[i];
                Console.Write(firstArray[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
