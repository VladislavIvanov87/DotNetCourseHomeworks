namespace Budget
{
    using System;

    public class Info
    {

        public Info(DateTime date, string expense, double price)
        {
            this.Date = date;
            this.Expense = expense;
            this.Price = price;
        }

        public DateTime Date { get; set; }

        public string Expense { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", this.Date, this.Expense, this.Price);
        }
    }
}