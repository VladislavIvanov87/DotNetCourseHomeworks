namespace Task4
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Convertor convertor = new Convertor(37);
            convertor.ConvertCelsiusToFahrenheit();

            Convertor newConvertor = new Convertor();
            newConvertor.Celsius = 25;
            newConvertor.ConvertCelsiusToFahrenheit();
        }
    }
}
