using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Budget
{
    public partial class ShowAllProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var showProducts = Operations.TakeInfoFromTheBase();
            this.Repeater.DataSource = showProducts;
            this.Repeater.DataBind();
        }
    }
}