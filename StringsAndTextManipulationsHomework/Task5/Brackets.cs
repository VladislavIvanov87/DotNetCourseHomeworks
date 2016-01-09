namespace Task5
{
    using System;

    class Brackets
    {
        static void Main()
        {
            Console.WriteLine("Enter the expression: ");
            string expression = Console.ReadLine();

            int result = Correct(expression);

            if (result == 0 && Check(expression))
            {
                Console.WriteLine("{0} is correct format.", expression);
            }
            else
            {
                Console.WriteLine("{0} is NOT correct format.", expression);
            }
        }
        static int Correct(string expression)
        {
            int counter = 0;
            char[] array = expression.ToCharArray();
            foreach (var item in array)
            {
                if (item == '(')
                {
                    counter++;
                }
                else if (item == ')' && counter != 0)
                {
                    counter--;
                }
            }
            return counter;
        }

        static bool Check(string expression)
        {
            if (expression.IndexOf("(") > expression.IndexOf(")"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}