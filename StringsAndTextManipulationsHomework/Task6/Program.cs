namespace Task6
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\firstFile.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\secondFile.txt"))
                {
                    string line = reader.ReadLine();
                    char[] separator = { ',', '.', '!', '?', ';', ':' };

                    while (line != null)
                    {
                        string[] newText = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in newText)
                        {
                            writer.WriteLine(item);
                        }

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
