using System;

namespace Task2
{
    class Greeting
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(PrintGreeting(name));
        }

        private static string PrintGreeting(string name)
        {
            return "Greetings, " + name + "!";
        }
    }
}
