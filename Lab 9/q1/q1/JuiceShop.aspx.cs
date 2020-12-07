using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q1
{
    public partial class JuiceShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                List<string> Fruits = new List<string>();
                Fruits.Add("Mango");
                Fruits.Add("Chickoo");
                Fruits.Add("Apple");
                Fruits.Add("Dragon Fruit");

                List<string> Icecreams = new List<string>();
                Icecreams.Add("Vanilla");
                Icecreams.Add("Chocolate");
                Icecreams.Add("Kitkat");
                Icecreams.Add("Oreo");

                CheckBoxList1.DataSource = Fruits;
                RadioButtonList1.DataSource = Icecreams;

                this.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "<h4>" + "You chose: " + "</h4>" + "<br/>" + "<b>" + "Fruits: " + "</b>" + "<br/>";
            foreach(ListItem itm in CheckBoxList1.Items)
            {
                if(itm.Selected == true)
                {
                    Label1.Text += itm.Text + "<br/>";
                }
            }

            Label1.Text += "<b>" + "Icecream: " + "</b>" + "<br/>" + RadioButtonList1.SelectedItem.Text + "<br/>";
            Label1.Text += "<b>" + "Price: " + "</b>" + "Rs 70";
        }
    }
}