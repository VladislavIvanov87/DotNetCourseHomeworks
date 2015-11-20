using System;

namespace Task3
{
    class IsSame
    {
        static void Main()
        {
            Console.Write("Enter something: ");
            string firstString = Console.ReadLine();
            string secondString = "Hello World";
            
            bool isSame = (firstString == secondString);
            Console.WriteLine(isSame);
        }
    }
}
