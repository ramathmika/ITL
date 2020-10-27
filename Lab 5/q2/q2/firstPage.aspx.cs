using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q2
{
    public partial class firstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GoButton_Click(object sender, EventArgs e)
        {
            Session["Name"] = NameTextBox.Text;
            Session["Roll Number"] = RollTextBox.Text;
            Session["Subject"] = SubjectDropDownList.SelectedItem.Text;
            Response.Redirect("secondPage.aspx");
        }
    }
}