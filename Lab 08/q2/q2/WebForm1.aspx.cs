using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Configuration;
namespace q2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //Create dictionary of genres
                Dictionary<int, string> genres = new Dictionary<int, string>();
                genres.Add(0, "");
                genres.Add(1, "Comedy");
                genres.Add(2, "Romance");
                genres.Add(3, "Animated");

                //bind dictionary to dropdownlist
                DropDownList1.DataTextField = "Value";
                DropDownList1.DataValueField = "Key";
                DropDownList1.DataSource = genres;
                DropDownList1.DataBind();
                DropDownList1.SelectedIndex = -1;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Test_170905004ConnectionString"].ConnectionString;


            try
            {
                con.Open();
                
                SqlCommand command = new SqlCommand("SELECT name from Legends WHERE category=@category", con);
                command.Parameters.AddWithValue("@category", DropDownList1.SelectedItem.Text);
                
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListBox1.Items.Add(reader["name"].ToString());
                }
            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Test;Integrated Security=True";
            //try
            //{
            //    con.Open();
            //    SqlCommand command = new SqlCommand("SELECT name, age from Legends WHERE name=@name and category=@category", con);
            //    command.Parameters.AddWithValue("@name", ListBox1.SelectedItem.Text);
            //    command.Parameters.AddWithValue("@category", DropDownList1.SelectedItem.Text);
                
            //    DataSet ds = new DataSet();
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    adapter.Fill(ds, "details");
                
            //    DataRow row = ds.Tables["details"].Rows[0];
            //    TextArea1.InnerText = "Name: ";
            //    TextArea1.InnerText += row["name"];
            //    TextArea1.InnerText += "Age: ";
            //    TextArea1.InnerText += row["age"];

            //}
            //finally
            //{
            //    con.Close();
            //}
        }
    }
}