using System;

namespace Task3
{
    class Cards
    {
        static void Main()
        {
            Console.Write("Enter a symbol that represents valid card: ");
            string symbol = Console.ReadLine();

            switch (symbol)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10": 
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("Valid card");
                    break;

                default: Console.WriteLine("Invalid card");
                    break;
            }
        }
    }
}
