namespace Task4
{
    using System;

    class ExtractSentence
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string word = Console.ReadLine();

            string[] sentence = text.Split('.', '!', '?');

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i].Contains(word))
                {
                    Console.WriteLine(sentence[i].Trim() + ('.'));
                }
            }
        }
    }
}
