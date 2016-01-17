namespace Task4
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 100);
            }

            int startArraySort = Environment.TickCount;
            Array.Sort(numbers);
            Console.WriteLine("Array sort in miliseconds: " + (Environment.TickCount - startArraySort));
            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //Sort odd numbers
            int startSort = Environment.TickCount;
            var sortedOdd = numbers
                .Where(number => number % 2 == 1)
                .OrderByDescending(number => number);
            Console.WriteLine("Array sort in milisecond: " + (Environment.TickCount - startSort));

            //foreach (var item in sortedOdd)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //Sort even numbers
            int lastArray = Environment.TickCount;
            var sortedEven = numbers
                .Where(number => number % 2 == 0)
                .OrderBy(number => number);
            Console.WriteLine("Array sort in miliseconds: " + (Environment.TickCount - lastArray));

            //foreach (var item in sortedEven)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
        }
    }
}
