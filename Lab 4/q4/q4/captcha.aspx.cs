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
        //To keeP a count on number of tries
        static int count;

        //Initialise the text in each image
        string[] text = { "T4Y9", "D56Y", "3G6B", "P35B" };

        //To choose a random captcha from tthe set of images
        Random r = new Random();
        static int num;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(this.IsPostBack == false)
            {
                count = 0;
                num = r.Next(0, 3);

                string url = "~/Images/captcha" + num.ToString() + ".jpg";
                CaptchaImage.ImageUrl = url;

            }
        }

        protected void AttemptMade(object sender, EventArgs e)
        {
            count++;
            if(count < 3)
            {
                string attempt = CaptchaTextBox.Text;
                if(attempt == text[num])
                {
                    ResultLabel.Text = "Correct!";
                    CaptchaTextBox.Text  = attempt;
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