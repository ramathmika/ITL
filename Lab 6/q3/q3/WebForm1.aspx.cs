using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (Session["Theme"] != null)
                {
                    DropDownList1.Items.FindByText(Session["Theme"].ToString()).Selected = true;
                }
            }
            
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if(Session["Theme"] != null)
            {
                Page.Theme = Session["Theme"].ToString();
                Label2.Text = Session["Text"].ToString();
                body1.Style[HtmlTextWriterStyle.BackgroundImage] = Session["Path"].ToString();

            }
        }

        protected void ChangeTheme(object sender, EventArgs e)
        {
            string res, path;
            if(DropDownList1.SelectedItem.Text == "Monsoon")
            {
                res = "Monsoon Theme";
                Label2.Text = "Monsoon Theme";
                path = "/App_Themes/Monsoon/monsoon.jpg";
                body1.Style[HtmlTextWriterStyle.BackgroundImage] = "/App_Themes/Monsoon/monsoon.jpg";
            }
            else
            {
                res = "Summer Theme";
                Label2.Text = "Summer Theme";
                path = "/App_Themes/Summer/summer.jpg";
                body1.Style[HtmlTextWriterStyle.BackgroundImage] = "/App_Themes/Summer/summer.jpg";
            }


            Session["Theme"] = DropDownList1.SelectedValue;
            Session["Text"] = res;
            Session["Path"] = path;
            Response.Redirect(Request.FilePath);

        }
    }
}