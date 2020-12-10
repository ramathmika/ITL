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


                //Get list of available font families
                InstalledFontCollection fonts = new InstalledFontCollection();
                foreach (FontFamily family in fonts.Families)
                    FontDropDownList.Items.Add(family.Name);

                //Choose default image
                ImageDropDownList.SelectedIndex = -1;

                //Make cover panel visible
                CoverPanel.Visible = true;

                //Make edit button not visible
                EditButtonPanel.Visible = false;

            }
        }

        private void UpdateCard()
        {
            //Update the colours
            CoverPanel.BackColor = Color.FromName(BackgoundDropDownList.SelectedItem.Text);

            //Update image
            if (ImageDropDownList.SelectedIndex != 0)
            {
                Image1.ImageUrl = "~/Images/" + ImageDropDownList.SelectedItem.Text + ".jpg";
            }
            else
                Image1.ImageUrl = "";
                


            //Update the font name and size
            GreetingsLabel.Font.Name = FontDropDownList.SelectedItem.Text;
            try
            {
                if (Int32.Parse(SizeTextBox.Text) > 0)
                {
                    GreetingsLabel.Font.Size = Int32.Parse(SizeTextBox.Text);
                }
            }
            catch
            {

            }

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
            EditButtonPanel.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Make the properties visible to configure and hide the edit button
            ConfigureDiv.Visible = true;
            EditButtonPanel.Visible = false;
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear entered texts and selections and set it back to default
            BackgoundDropDownList.SelectedIndex = 163;
            ImageDropDownList.SelectedIndex = 0;
            FontDropDownList.SelectedIndex = -1;
            SizeTextBox.Text = "";
            GreetingsTextBox.Text = "";
            UpdateCard();
        }
    }
}