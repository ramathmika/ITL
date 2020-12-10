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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DropDownList1.Items.Add(new ListItem("Samsung M20", "Screen: 6.30-inch (1080x2340) | Memory: 3+32GB | Camera: 8MP, 13+5MP | Battery: 5000mAh"));
                DropDownList1.Items.Add(new ListItem("iPhone X", "Screen: 5.80-inch (1125x2436) | Memory: 3+64GB | Camera: 7MP, 12+12MP | Battery: 2716mAh"));
                DropDownList1.Items.Add(new ListItem("OnePlus 7T", "Screen: 6.55-inch (1080x2400)) | Memory: 8+128GB | Camera: 16MP, 48+16+12MP | Battery: 3800mAh"));
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void IndexChanged(object sender, EventArgs e)
        {
            Session["Selected"] = DropDownList1.SelectedItem.Value;
            Site1 master = (Site1)this.Master;
            string res = "Selected Item is: " + "<br/>" + DropDownList1.SelectedItem.Text;
            Session["Label"] = res;
            Session["index"] = DropDownList1.SelectedIndex;
            master.ChangeLabel(res);
        }
    }
}