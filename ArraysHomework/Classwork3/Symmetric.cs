using System;

namespace Classwork3
{
    class Symmetric
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

            bool symmetric = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[length - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }
            Console.WriteLine("Is symmetric? {0}", symmetric);
        }
    }
}
