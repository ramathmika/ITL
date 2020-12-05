using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q4
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Label"] != null)
            {
                Label1.Text = Session["Label"].ToString();
            }
        }

        public void ChangeLabel(string val)
        {
            Label1.Text = val;
        }
    }
}
