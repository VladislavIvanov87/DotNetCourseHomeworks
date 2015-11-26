using System;

namespace Task2
{
    class Bonuses
    {
        static void Main()
        {
            Console.Write("Enter your points: ");
            int points = int.Parse(Console.ReadLine());

            if (points > 0 && points <= 9)
            {
                if (points >= 1 && points <= 3)
                {   
                    Console.WriteLine("Your bonus points are {0}", points += 5);
                }

                else if (points >= 4 && points <= 6)
                {
                    Console.WriteLine("Your bonus points are {0}", points *= 12);
                }
                else
                {   
                    Console.WriteLine("Your bonus point are {0}", points = (points * 50) / 3);
                }
            }

            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}
