using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sample
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                themeDropDown.Items.Add("Monochrome");
                themeDropDown.Items.Add("DarkGrey");
                if(Session["Theme"] != null)
                {
                    themeDropDown.Items.FindByText(Session["Theme"].ToString()).Selected = true;
                }
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if(Session["Theme"] != null)
            {
                Page.Theme = Session["Theme"].ToString();
            }
        }

        protected void themeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Theme"] = themeDropDown.SelectedValue;
            Response.Redirect(Request.FilePath);
        }
    }
}