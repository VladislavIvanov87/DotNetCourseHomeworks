using System;

namespace Task9
{
    class Index
    {
        static void Main()
        {
            string myString = Console.ReadLine();
            Console.Write("Enter index of the string: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(myString[n]);
        }
    }
}
