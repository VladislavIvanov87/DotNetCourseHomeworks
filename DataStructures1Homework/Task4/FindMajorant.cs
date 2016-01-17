namespace Task4
{
    using System;
    using System.Collections.Generic;

    class FindMajorant
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int minMajorantLength = (numbers.Count / 2) + 1;
            bool majorantFound = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                int count = numbers.FindAll(x => x == number).Count;

                if (count >= minMajorantLength)
                {
                    Console.WriteLine("The majorant is --> {0}", number);
                    majorantFound = true;
                    break;
                }
            }

            if (!majorantFound)
            {
                Console.WriteLine("The majorant does not exists!");
            }
        }
    }
}
