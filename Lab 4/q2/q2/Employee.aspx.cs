using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q2
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                //Add Employee IDs to the dropdown list
                EmployeeIDList.Items.Add("1001");
                EmployeeIDList.Items.Add("1002");
                EmployeeIDList.Items.Add("1003");
                EmployeeIDList.Items.Add("1004");
                EmployeeIDList.Items.Add("1005");

                //EmployeeIDList.Items.Insert(0, new ListItem(string.Empty, string.Empty));
                EmployeeIDList.SelectedIndex = -1;
            }
        }
        protected void UpdateInfo(Object sender, EventArgs e)
        {
            string imageurl = "~/Images/" + EmployeeIDList.SelectedItem.Text + ".jpg";
            EmployeeImage.ImageUrl = imageurl;
        }

        protected void PrintResult(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            int year = date.Year;
            string[] data = DOJTextBox.Text.Split('-');
            var JoinedYear = data[0];
            EmployeeTextBox.Text = JoinedYear;
            if (year - Int32.Parse(JoinedYear) > 5)
                ResultLabel.Text = "YES";
            else
                ResultLabel.Text = "NO";

        }
    }
}