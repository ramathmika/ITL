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
            if (!this.IsPostBack)
            {
                //Add items to the dropdownlist
                DropDownList1.Items.Add(new ListItem("Toyota", "Innova"));
                DropDownList1.Items.Add(new ListItem("Maruti", "Suzuki"));
                DropDownList1.Items.Add(new ListItem("Tesla", "Model 3"));
                DropDownList1.Items.Add(new ListItem("BMW", "x5"));

                DropDownList1.SelectedIndex = -1;
            }
            else
            {
                //Update the model name
                TextBox1.Text = DropDownList1.SelectedItem.Value;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update the model name
            TextBox1.Text = DropDownList1.SelectedItem.Value;

            //Redirect to next page
            string url = "WebForm2.aspx?";
            url += "Manufacturer=" + Server.UrlEncode(DropDownList1.SelectedItem.Text) + "&";
            url += "Model=" + Server.UrlEncode(TextBox1.Text);
            Response.Redirect(url);
        }
    }
}