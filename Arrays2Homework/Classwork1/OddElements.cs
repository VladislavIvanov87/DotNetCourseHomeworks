using System;

namespace Classwork1
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = new int[4, 4];
            int counter = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {   
                    matrix[row, col] = counter;
                    counter++;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] % 2 == 1)
                    {
                        Console.WriteLine(matrix[row, col] * 2);
                    }
                }
            }
        }
    }
}
