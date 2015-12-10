namespace Task2
{
    using System;

    class Automobile : Car
    {
        public string FuelConsumption {get; set;}

        public Automobile(string price, string fuelConsumption)
            : base(price)
        {
            this.FuelConsumption = fuelConsumption;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Price, this.FuelConsumption);

        }
    }
}
