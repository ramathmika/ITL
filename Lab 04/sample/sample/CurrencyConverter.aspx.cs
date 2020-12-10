using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sample
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fromCurrencyDropDown.Items.Add(new ListItem("INR", "65.3"));
                fromCurrencyDropDown.Items.Add(new ListItem("Yen", "110.33"));
                fromCurrencyDropDown.Items.Add(new ListItem("Euro", "0.85"));
            }
        }
        protected void SubmitClickedEvent(object sender, EventArgs e)
        {
            string convertedValue = convertCurrency();
            labelAns.Text = convertedValue.ToString();
        }
        string convertCurrency()
        {
            double oldVal = 0;
            double newVal = 0;
            double.TryParse(inputCurrency.Text, out oldVal);
            ListItem temp = fromCurrencyDropDown.Items[fromCurrencyDropDown.SelectedIndex];
            newVal = oldVal * double.Parse(temp.Value);
            string s = oldVal.ToString() + "USD = " + newVal.ToString() + " " + temp.Text;
            return s;
        }
    }
}