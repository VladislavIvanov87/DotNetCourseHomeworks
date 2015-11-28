using System;

namespace Task2
{
    class FillTheMatrix
    {
        static void Main()
        {
            int[,] matrix = new int[3, 4];

            Console.WriteLine("Fill the matrix: ");
            Console.WriteLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("matrix[{0}, {1}]: ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
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
        }
    }
}
