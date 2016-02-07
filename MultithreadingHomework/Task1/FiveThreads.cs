namespace Task1
{
    using System;
    using System.Threading;

    class FiveThreads
    {
        static void Main()
        {
            Random rand = new Random();

            Thread firstThread = new Thread(new ThreadStart(new ThreadClass("First", rand).ShowInfo));
            firstThread.Start();
            Thread secondThread = new Thread(new ThreadStart(new ThreadClass("Second", rand).ShowInfo));
            secondThread.Start();
            Thread thirdThread = new Thread(new ThreadStart(new ThreadClass("Third", rand).ShowInfo));
            thirdThread.Start();
            Thread fourthThread = new Thread(new ThreadStart(new ThreadClass("Fourth", rand).ShowInfo));
            fourthThread.Start();
            Thread fifthThread = new Thread(new ThreadStart(new ThreadClass("Fifth", rand).ShowInfo));
            fifthThread.Start();
        }
    }
}
