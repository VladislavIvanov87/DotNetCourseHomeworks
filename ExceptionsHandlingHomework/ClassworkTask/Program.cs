namespace ClassworkTask
{
    using System;

    class Program
    {
        static void Main()
        {
            try
            {
                User firstUser = new User("firstUser@gmail.com", "1234");
                User secondUser = new User("secondUserabvbg", "FF16SS");
                User thirdUser = new User("thirdUser@yahoo.com", "R2D2BB8");   
            }
            catch (EmailException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
