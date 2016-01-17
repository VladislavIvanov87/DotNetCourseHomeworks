namespace Task2
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var words = text.Split(new char[] { ' ', ',', '.', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> result = new HashSet<string>(words);

            foreach (var word in result)
            {
                Console.WriteLine(word);
            } 
        }
    }
}
