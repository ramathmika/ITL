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
                HttpCookie cookie = Request.Cookies["Shoppin"];
                Label4.Text = "";
                if(cookie == null)
                {
                    Input_Panel.Visible = true;
                    Label1.Visible = false;
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Welcome " + cookie["name"] + "<br />";
                    Label4.Text += "Current cart is: <br />" + cookie["cart"];
                    TextBox1.Text = cookie["name"];
                    Input_Panel.Visible = false;

                    
                }
            }
        }


        protected void UpdateCart()
        {
            
            HttpCookie cookie = Request.Cookies["Shoppin"];
            if (cookie == null)
            {
                cookie = new HttpCookie("Shoppin");
                cookie["cart"] = "";
                
            }

            

            foreach(ListItem litem in CheckBoxList1.Items)
            {
                if (litem.Selected == true)
                {
                    cookie["cart"] += litem.Text + ", ";
                }
                
            }

            Label4.Text = "Current cart is: <br />" + cookie["cart"];



            cookie["name"] = TextBox1.Text;

            Response.Cookies.Add(cookie);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UpdateCart();
            Input_Panel.Visible = true; 

        }
    }
}