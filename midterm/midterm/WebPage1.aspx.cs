using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace midterm
{
    public partial class WebPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //Add items to FROM list
                FromDropDownList.Items.Add("inches");
                FromDropDownList.Items.Add("centimeters");

                //Add items to TO list
                ToDropDownList.Items.Add("feet");
                ToDropDownList.Items.Add("millimeters");

                //Add items to radiolist
                RadioButtonList1.Items.Add("Human");
                RadioButtonList1.Items.Add("Robot");

                //Clear label3
                Label3.Text = "";
            }
        }

        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            //1inch = 0.08333ft, 25.4mm
            //1cm = 0.032808ft, 10mm

            Label3.Text = "";

            string from = FromDropDownList.SelectedItem.Text;
            string to = ToDropDownList.SelectedItem.Text;
            decimal result = 0M;
            decimal input = 0M;
            try
            {
                input = Convert.ToDecimal(ValueTextBox.Text);
            }
            catch
            {
                Label3.Text = "Enter a value";
            }
            if(input <= 0)
            {
                Label3.Text = "Enter a positive value";
            }
            else
            {
                switch (from)
                {
                    case "inches":
                        if (to == "feet")
                        {
                            result = input * 0.08333M;
                        }
                        else if (to == "millimeters")
                        {
                            result = input * 25.4M;
                        }
                        else
                        {
                            Label3.Text = "Select a to option.";
                        }
                        break;
                    case "centimeters":
                        if (to == "feet")
                        {
                            result = input * 0.032808M;
                        }
                        else if (to == "millimeters")
                        {
                            result = input * 10M;
                        }
                        else
                        {
                            Label3.Text = "Select a to option.";
                        }
                        break;
                    case null:
                        Label3.Text = "Select a from option";
                        break;
                }

                if (RadioButtonList1.SelectedIndex == 0)
                {
                    string url = "WebPage2.aspx?";
                    url += "value=" + ValueTextBox.Text + "&";
                    url += "from=" + from + "&";
                    url += "to=" + to + "&";
                    url += "result=" + result.ToString();

                    Response.Redirect(url);
                }
                else if (RadioButtonList1.SelectedIndex == 1)
                {
                    Label1.Text = result.ToString();
                }
                else
                {
                    Label3.Text = "Enter all input properly";
                }
            }

            
        }

        protected void CounterButton_Click(object sender, EventArgs e)
        {
            Label3.Text = "";


            int count;
            if (Application["count"] == null)
                count = 1;
            else
                count = (int)Application["count"] + 1;

            Application["count"] = count;

            if (RadioButtonList1.SelectedIndex == 0)
            {
                Label2.Text = "Page visited " + count + " number of times.";
            }
            else if (RadioButtonList1.SelectedIndex == 1)
            {
                int attempts;
                if (Application["attempts"] == null)
                    attempts = 1;
                else
                    attempts = (int)Application["attempts"] + 1;

                Application["attempts"] = attempts;

                if(attempts == 1)
                {
                    Label2.Text = attempts.ToString() + " attempt.";
                }
                else
                {
                    RadioButtonList1.Enabled = false;
                    Label2.Text = "Radio Button disabled";
                }
            }
            else
            {
                Label3.Text = "Select an option in radiobutton list";
            }
        }
    }
}