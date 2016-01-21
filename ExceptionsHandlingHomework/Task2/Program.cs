namespace Task2
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            try
            {
                using (StreamReader reader = new StreamReader("file.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (CheckSentence(line))
                        {
                            Console.WriteLine(line);
                            line = reader.ReadLine();
                        }
                        else
                        {
                            throw new SentenceNotCompletedException("Your sentence is not completed!");
                        } 
                    }
                }
            }
            
            catch (SentenceNotCompletedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static bool CheckSentence(string line)
        {
            if (line.EndsWith(".") || line.EndsWith("!") || line.EndsWith("?"))
            {
                return true;
            }
            
                return false;
        }
    }
}
