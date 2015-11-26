using System;

namespace Task1
{
    class IntDoubleOrString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:\n1--> for Integer\n2--> for Double\n3--> for String");
            byte choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter number: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(++number);
                    break;
                
                case 2: Console.Write("Enter real number: ");
                    double realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine(++realNumber);
                    break;
                
                case 3: Console.Write("Enter text: ");
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;

                default: Console.WriteLine("Your choice is not correct");
                    break;
            }
        }
    }
}
