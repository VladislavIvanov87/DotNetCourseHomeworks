namespace Countries
{
    using System;

    public partial class AddCountry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            var countryToAdd = new CountryInfo(
                this.CountryTextBox.Text,
                this.CapitalTextBox.Text,
                this.PopulationTextBox.Text);

            if (Operations.AddCountry(countryToAdd))
            {
                this.MessageLabel.Text = "Successfully added";
                this.CountryTextBox.Text = string.Empty;
                this.CapitalTextBox.Text = string.Empty;
                this.PopulationTextBox.Text = string.Empty;
            }
            else
            {
                this.MessageLabel.Text = "An error occured while adding the country";
            }
        }
    }
}