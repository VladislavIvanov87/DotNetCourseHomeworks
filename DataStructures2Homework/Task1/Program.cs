namespace Task1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word.ToLower(), 1);
                }
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine("{0} --> {1}", word.Key, word.Value);
            }
        }
    }
}
