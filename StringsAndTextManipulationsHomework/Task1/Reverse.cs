namespace Task1
{
    using System;
    using System.Text;

    class Reverse
    {
        static void Main()
        {
            string word = "backwards";
            string reversed = ReverseWord(word);
            Console.WriteLine(word);
            Console.WriteLine(reversed);
        }

        private static string ReverseWord(string word)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }
            return sb.ToString();
        }
    }
}
