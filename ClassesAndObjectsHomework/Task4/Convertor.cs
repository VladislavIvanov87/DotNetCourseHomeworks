namespace Task4
{
    using System;

    public class Convertor
    {
        public double Celsius {get; set;}
        
        public Convertor(double celsius)
        {
            this.Celsius = celsius;
        }

        public Convertor()
        {
        }

        public void ConvertCelsiusToFahrenheit()
        {
            double degreesInFahrenheit = (Celsius * 9) / 5 + 32;
            Console.WriteLine("The result is " + degreesInFahrenheit);
        }
    }
}
