using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace midterm
{
    public partial class WebPage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "You are redirected from WebPage1." + "<br/>";
            Label1.Text += "Input value: " + Request.QueryString["value"] + "<br/>";
            Label1.Text += "From: " + Request.QueryString["from"] + "<br/>";
            Label1.Text += "To: " + Request.QueryString["to"] + "<br/>";
            Label1.Text += "Result: " + Request.QueryString["result"];
        }
    }
}