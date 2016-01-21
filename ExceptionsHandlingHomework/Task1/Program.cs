namespace Task1
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            try
            {
                string fileName = "example.txt";
                ReadFile(fileName);

                string otherFile = "otherExample.txt";
                WriteFile(otherFile);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch(IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }
        }

        private static void ReadFile(string fileName)
        {
            using (StreamReader reader = new StreamReader("example.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                } 
            }
        }

        private static void WriteFile(string otherFile)
        {
            using (StreamWriter writer = new StreamWriter("otherExample.txt"))
            {
                writer.WriteLine(Console.ReadLine());
            }
        }
    }
}
