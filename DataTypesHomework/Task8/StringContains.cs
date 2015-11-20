using System;

namespace Task8
{
    class StringContains
    {
        static void Main()
        {
            string s1 = "This is a test string";
            string s2 = "test";

            bool b = s1.Contains(s2);

            Console.WriteLine("{0} is in the string '{1}' - {2}", s2, s1, b);
            Console.WriteLine();
        }
    }
}
