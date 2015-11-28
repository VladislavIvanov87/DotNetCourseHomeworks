using System;

namespace Task5
{
    class VerticalMatrix
    {
        static void Main()
        {
            Console.Write("Enter the length of the rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the length of the columns: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            int counter = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
