using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT StaffID from Staff", con);
                    SqlDataReader reader; 
                    reader = command.ExecuteReader();
                    while (reader.Read())
                        DropDownList1.Items.Add(reader["StaffID"].ToString());
                }
                catch
                {

                }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";
            SqlCommand command = new SqlCommand("UPDATE Staff SET City=@City where StaffID=@StaffID", con);
            command.Parameters.AddWithValue("@City", ListBox1.SelectedItem.Text);
            command.Parameters.AddWithValue("@StaffID", DropDownList1.SelectedItem.Text);

            try
            {
                con.Open();
                int count = command.ExecuteNonQuery();
                Label1.Text = "Updated: " + count; 
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";
            SqlCommand command = new SqlCommand("SELECT StaffID, City from STAFF where StaffID=@StaffID", con);
            command.Parameters.AddWithValue("@StaffID", DropDownList1.SelectedItem.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds, "Staff_Details");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}