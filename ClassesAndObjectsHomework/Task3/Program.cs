namespace Task3
{
    using System;

    public class Program
    {
        static void Main()
        {
            RightAngledTriangle firstTriangle = new RightAngledTriangle(3, 2);
            firstTriangle.FindingTheHypotenuse();

            RightAngledTriangle secondTriangle = new RightAngledTriangle(5, 4);
            secondTriangle.FindingTheHypotenuse();
        }
    }
}
