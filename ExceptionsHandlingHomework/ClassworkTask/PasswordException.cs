namespace ClassworkTask
{
    using System;

    public class PasswordException : Exception
    {
        public PasswordException(string message)
            : base(message)
        {

        }
    }
}
