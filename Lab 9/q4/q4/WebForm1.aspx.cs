using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                List<string> categories = new List<string>();
                categories.Add("Comedy");
                categories.Add("Romance");
                categories.Add("Animated");

                DropDownList1.DataSource = categories;
                DropDownList1.DataBind();
            }
        }
    }
}
