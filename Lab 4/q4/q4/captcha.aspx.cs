using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q4
{
    public partial class captcha : System.Web.UI.Page
    {
        static int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(this.IsPostBack == false)
            {
                count = 0;
            }
        }

        protected void AttemptMade(object sender, EventArgs e)
        {
            count++;
            if(count < 3)
            {
                string attempt = CaptchaTextBox.Text;
                if(attempt == "T4Y9")
                {
                    ResultLabel.Text = "Correct!";
                }
                else
                {
                    string res = "Try again. " + (3 - count).ToString() + " attempts left.";
                    ResultLabel.Text = res;
                    CaptchaTextBox.Text = "";
                }
            }
            else
            {
                CaptchaTextBox.Visible = false;
                ResultLabel.Text = "Too many wrong attempts.";
            }
        }
    }
}