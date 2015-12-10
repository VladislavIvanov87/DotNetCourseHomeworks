namespace Task3
{
    using System;

    public class RightAngledTriangle
    {
        public double FirstCathetus {get; set;}

        public double SecondCathetus {get; set;}

        public RightAngledTriangle(double a, double b)
        {
            this.FirstCathetus = a;
            this.SecondCathetus = b;
        }

        public RightAngledTriangle()
        {
        }

        public void FindingTheHypotenuse()
        {
            double c = Math.Sqrt((FirstCathetus * FirstCathetus) + (SecondCathetus * SecondCathetus));
            Console.WriteLine("The hypotenuse is {0}", c);
        }
    }
}
