using System;

namespace Task4
{
    class Rectangle
    {
        static void Main()
        {
            Console.Write("Enter the length of the rectangle: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            int width = int.Parse(Console.ReadLine());

            int S = length * width;
            Console.WriteLine("The area of the rectangle is {0}", S);
        }
    }
}
