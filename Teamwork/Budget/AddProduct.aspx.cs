namespace Budget
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.IO;

    public partial class AddProduct : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {

            var infoToAdd = new Info(
                DateTime.Parse(this.DateTextBox.Text),
                this.ExpenseTextBox.Text,
                double.Parse(this.PriceTextBox.Text));

            try
            {
                if (Operations.AddInfo(infoToAdd))
                {
                    this.MessageLabel.Text = "Successfully added!";
                    this.DateTextBox.Text = string.Empty;
                    this.ExpenseTextBox.Text = string.Empty;
                    this.PriceTextBox.Text = string.Empty;
                }
            }

            catch (Exception ex)
            {
                this.MessageLabel.Text = ex.Message;
            }
        }
    }
}