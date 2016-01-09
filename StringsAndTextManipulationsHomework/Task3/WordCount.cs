namespace Task3
{
    using System;
    using System.Text.RegularExpressions;

    class WordCount
    {
        static void Main()
        {
            string text = "This is just test. Nothing but test. Test, tester!";
            MatchCollection matches = Regex.Matches(text, @"\btest\b", RegexOptions.IgnoreCase);
            int count = matches.Count;
            Console.WriteLine("The word \"test\" appears {0} times.", count);
        }
    }
}