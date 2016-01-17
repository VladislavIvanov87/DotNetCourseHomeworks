namespace Task3
{
    using System;
    using System.Collections.Generic;

    class CountOccurences
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var occurences = new int[1001];

            foreach (var number in numbers)
            {
                occurences[number]++;
            }

            for (int i = 0; i < occurences.Length; i++)
            {
                if (occurences[i] != 0)
                {
                    Console.WriteLine("{0} -> {1}", i, occurences[i]);
                }
            }
        }
    }
}
