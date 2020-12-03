using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web.UI.HtmlControls;
using System.Drawing.Text;

namespace q4
{
    public partial class CoverGenerator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack != true)
            {
                //Get list of available colours
                string[] colours = Enum.GetNames(typeof(KnownColor));

                BackgoundDropDownList.DataSource = colours;
                BackgoundDropDownList.DataBind();
                BackgoundDropDownList.SelectedIndex = 163;

                TextDropDownList.DataSource = colours;
                TextDropDownList.DataBind();
                TextDropDownList.SelectedIndex = 34;

                //Get list of available font families
                InstalledFontCollection fonts = new InstalledFontCollection();
                foreach (FontFamily family in fonts.Families)
                    FontDropDownList.Items.Add(family.Name);

                //Get the border styles
                string[] borderStyles = Enum.GetNames(typeof(BorderStyle));

                BorderRadioButtonList.DataSource = borderStyles;
                BorderRadioButtonList.DataBind();
                BorderRadioButtonList.SelectedIndex = 0;

                //Choose default image
                ImageDropDownList.SelectedIndex = 0;

                //Make cover panel visible
                CoverPanel.Visible = true;

            }
        }

        private void UpdateCard()
        {
            //Update the colours
            CoverPanel.BackColor = Color.FromName(BackgoundDropDownList.SelectedItem.Text);
            GreetingsLabel.ForeColor = Color.FromName(TextDropDownList.SelectedItem.Text);
            
            //Update background image
            string imageURL = "~/Images/" + ImageDropDownList.SelectedItem.Text + ".jpg";
            CoverPanel.BackImageUrl = imageURL;

            //Update the font name and size
            GreetingsLabel.Font.Name = FontDropDownList.SelectedItem.Text;
            try
            {
                if (Int32.Parse(SizeTextBox.Text)>0) {
                    GreetingsLabel.Font.Size = Int32.Parse(SizeTextBox.Text);
                }
            }
            catch
            {

            }

            //Get the correct TypeConverter for BorderStyle enumeration
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(BorderStyle));

            //Upfate the border style
            CoverPanel.BorderStyle = (BorderStyle)converter.ConvertFromString(BorderRadioButtonList.SelectedItem.Text);

            //Set the text
            GreetingsLabel.Text = GreetingsTextBox.Text;
        }

        protected void ControlChanged(Object sender, EventArgs e)
        {
            //Update and refresh the cover
            UpdateCard();
        }

        protected void PreviewButton_Click(object sender, EventArgs e)
        {
            //Update and refresh the cover and hide the div
            UpdateCard();
            ConfigureDiv.Visible = false;
        }
    }
}