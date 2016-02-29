namespace Countries
{
    using System;
    using System.Linq;

    public partial class SearchByPopulationInRange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var countries = Operations.ReadFromDataBase();

            foreach (var item in countries)
            {
                if (this.DropDownList.SelectedValue == "Small countries")
                {
                    this.repeater.DataSource = countries.Where(x => x.PopulationInRange == "1 000 000 - 10 000 000");
                    this.repeater.DataBind();
                }
                else if (this.DropDownList.SelectedValue == "Big countries")
                {
                    this.repeater.DataSource = countries.Where(x => x.PopulationInRange == "10 000 000 - 100 000 000");
                    this.repeater.DataBind();
                }
                else
                {
                    this.repeater.DataSource = countries.Where(x => x.PopulationInRange == "100 000 000 - 2 000 000 000");
                    this.repeater.DataBind();
                }
            }
        }
    }
}