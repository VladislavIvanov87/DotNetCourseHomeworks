namespace Task3
{
    using System;
    using System.Threading;

    public class ThreadClass
    {
        public void PrintNumbers()
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void PrintText()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Running");
                Thread.Sleep(500);
            }
        }
    }
}
