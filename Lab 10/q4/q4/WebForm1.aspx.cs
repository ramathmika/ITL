using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DropDownList1.Items.Add("--Select--");
                foreach(var drive in DriveInfo.GetDrives())
                {
                    DropDownList1.Items.Add(drive.Name);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@DropDownList1.SelectedItem.Text);
            FileInfo[] files = directoryInfo.GetFiles();

            ListBox1.Items.Clear(); 

            foreach(FileInfo file in files)
            {
                ListBox1.Items.Add(file.Name);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@DropDownList1.SelectedItem.Text);

            File.Delete(directoryInfo.FullName + ListBox1.SelectedItem.Text);

            FileInfo[] files = directoryInfo.GetFiles();

            ListBox1.Items.Clear();

            foreach (FileInfo file in files)
            {
                ListBox1.Items.Add(file.Name);
            }
        }
    }
}