using System;

namespace Classwork1
{
    class CopyArray
    {
        static void Main()
        {
            int[] firstArray = new int[] { 6, 8, 12, 15, 22 };
            int[] secondArray = new int[firstArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray = firstArray;
                Console.Write(secondArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
