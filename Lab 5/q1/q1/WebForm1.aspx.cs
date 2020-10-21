using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.SelectedIndex = -1;
        }

        protected void ControlChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedIndex == -1)
            {
                Label1.Text = "Select an item";
            }
            else
            {
                string url = "WebForm2.aspx?";
                url += "Manufacturer=" + Server.UrlEncode(DropDownList1.SelectedItem.Text) + "&";
                url += "Model=" + Server.UrlEncode(TextBox1.Text);
                Response.Redirect(url);

            }
        }
    }
}