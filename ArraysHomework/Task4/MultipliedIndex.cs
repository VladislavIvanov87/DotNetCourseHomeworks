using System;

namespace Task3
{
    class MultipliedIndex
    {
        static void Main()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 10;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
