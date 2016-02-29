using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Countries
{
    public partial class ShowInfoForTheCountry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "";
            var allCountries = Operations.ReadFromDataBase();
            var foundCountries = new List<CountryInfo>();

            foreach (var item in allCountries.Where(item => 
            item.Country.ToLower().Contains(this.KeywordTextBox.Text.ToLower()) ||
            item.Capital.ToLower().Contains(this.KeywordTextBox.Text.ToLower())))
            {
                foundCountries.Add(item);
            }

            this.repeater.DataSource = foundCountries;
            this.repeater.DataBind();
        }
    }
}