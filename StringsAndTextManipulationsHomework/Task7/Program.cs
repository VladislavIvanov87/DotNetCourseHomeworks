namespace Task7
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("numbers.txt"))
            {
                using (StreamWriter firstWriter = new StreamWriter("oddLines.txt"))
                {
                    using (StreamWriter secondWriter = new StreamWriter("evenLines.txt"))
                    {
                        int lineNumber = 1;
                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            if (lineNumber % 2 == 1)
                            {
                                firstWriter.WriteLine(line);
                            }
                            else
                            {
                                secondWriter.WriteLine(line);
                            }

                            lineNumber++;
                            line = reader.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
