using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q2
{
    public partial class secondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string name = (string)Session["Name"];
                Label1.Text = "Name: " + name + "<br />";
                string roll = (string)Session["Roll Number"];
                Label1.Text += "Roll Number: " + roll + "<br />";
                string subject = (string)Session["Subject"];
                Label1.Text += "Selected Subject: " + subject;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int counter;
            HttpCookie cookie = Request.Cookies["Click"];

            if (cookie == null)
            {
                cookie = new HttpCookie("Click");
                counter = 1;
            }
            else
                counter = Int32.Parse(cookie["Count"]) + 1;

            cookie["Count"] = counter.ToString();
            Response.Cookies.Add(cookie);

            Label2.Text = "Button clicked " + counter + " times.";

        }
    }
}