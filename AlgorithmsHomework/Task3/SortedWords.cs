namespace Task3
{
    using System;
    using System.Collections.Generic;

    class SortedWords
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            IDictionary<string, int> sortedDict = new SortedDictionary<string, int>();

            foreach (var word in words)
            {
                if (sortedDict.ContainsKey(word))
                {
                    sortedDict[word]++;
                }
                else
                {
                    sortedDict.Add(word, 1);
                }
            }

            foreach (var word in sortedDict)
            {
                Console.WriteLine("{0}", word.Key);
            }
        }
    }
}
