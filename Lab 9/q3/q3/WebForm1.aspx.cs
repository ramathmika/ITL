using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace q3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Dictionary<int, string> states = new Dictionary<int, string>();
                states.Add(0, "Karnataka");
                states.Add(1, "Maharashtra");
                states.Add(2, "Tamil Nadu");

                DropDownList1.DataSource = states;
                DropDownList1.DataTextField = "Value";
                DropDownList1.DataValueField = "Key";
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "Welcome to " + DropDownList2.SelectedValue + ", " + DropDownList1.SelectedItem.Text;
        }
    }
}