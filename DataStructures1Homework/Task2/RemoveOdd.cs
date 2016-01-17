namespace Task2
{
    using System;
    using System.Collections.Generic;

    class RemoveOdd
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            List<int> newList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                int count = numbers.FindAll(x => x == number).Count;

                if (count % 2 == 0 && !newList.Contains(number))
                {
                    newList.Add(number);
                }
            }

            Console.WriteLine(string.Join(", ", newList));
        }
    }
}
