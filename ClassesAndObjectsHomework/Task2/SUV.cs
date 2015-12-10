namespace Task2
{
    using System;

    class SUV : Car
    {
        public bool IsOffRoad {get; set;}

        public SUV (string price, bool isOffRoad)
            : base(price)
        {
            this.IsOffRoad = isOffRoad;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Price, this.IsOffRoad);
        }
    }
}
