using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Budget
{
    public partial class CalculateExpenses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var calculatedDate = Operations.TakeInfoFromTheBase();
            double sumOfProducts = 0;

            foreach (var item in calculatedDate)
            {
                if (DateTime.Now.AddDays(-int.Parse(this.DropDownList.SelectedValue)) < item.Date && item.Date < DateTime.Now)
                {
                    sumOfProducts += item.Price;
                }
            }

            this.MessageLabel.Text = sumOfProducts.ToString();
        }
    }
}