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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Label1.Text = "Successfully Submitted";
            }
        }

        protected void val_Phone(object source, ServerValidateEventArgs e)
        {
            string num = TextBox3.Text;
            double t;
            if (num.Length == 10 && double.TryParse(num, out t))
            {
                e.IsValid = true;
            }
            else
                e.IsValid = false;
        }
    }
}