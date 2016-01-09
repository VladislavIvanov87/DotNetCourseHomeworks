namespace Task2
{
    using System;

    class WordToUpper
    {
        static void Main()
        {
            string word = "are";
            string text = "We are the champions. We are the best. We are №1.";
            string replaced = text.Replace(word, word.ToUpper());
            Console.WriteLine(replaced);
        }
    }
}
