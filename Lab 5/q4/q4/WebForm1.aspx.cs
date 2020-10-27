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
        string username = "Ramathmika";
        string password = "170905004";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int scounter, fcounter;

            if(TextBox1.Text == username && TextBox2.Text == password)
            {
                if (Application["success"] == null)
                    scounter = 1;
                else
                    scounter = (int)Application["success"] + 1;

                Application["success"] = scounter;

                Label1.Text = "Successfully logged in " + scounter + " number of times";
            }
            else
            {
                if (Session["fail"] == null)
                    fcounter = 1;
                else
                    fcounter = (int)Session["fail"] + 1;

                Session["fail"] = fcounter;

                if (fcounter <= 3)
                    Label1.Text = "Wrong username or password. Try again.";
                else
                {
                    TextBox1.Enabled = false;
                    TextBox2.Enabled = false;
                    Label1.Text = "More than 3 failed attempts.";
                }
            }

        }
    }
}