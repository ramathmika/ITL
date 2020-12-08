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
                con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping_170905004;Integrated Security=True";

                SqlCommand command = new SqlCommand("SELECT StaffID from Staff", con);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "Staff_Names");
                DropDownList1.DataSource = ds.Tables["Staff_Names"];
                DropDownList1.DataTextField = "StaffID";
                DropDownList1.DataBind();

                //try
                //{
                //    con.Open();
                //    SqlCommand command = new SqlCommand("SELECT StaffID from Staff", con);
                //    SqlDataReader reader; 
                //    reader = command.ExecuteReader();
                //    while (reader.Read())
                //        DropDownList1.Items.Add(reader["StaffID"].ToString());

                //    SqlDataAdapter adapter = new SqlDataAdapter(command);
                //    adapter.Fill(ds, "Staff_Names");
                //    DropDownList1.DataSource = ds.Tables["Staff_Names"];
                //    DropDownList1.DataTextField = "StaffID";
                //    DropDownList1.DataBind();
                //}
                //catch(Exception ex)
                //{
                //    Label1.Text = ex.Message;
                //}
                //finally
                //{
                //    con.Close();
                //}
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping_170905004;Integrated Security=True";
            
            SqlCommand command = new SqlCommand("UPDATE Staff SET City=@City where StaffID=@StaffID", con);
            command.Parameters.AddWithValue("@City", ListBox1.SelectedItem.Text);
            command.Parameters.AddWithValue("@StaffID", DropDownList1.SelectedItem.Text);

            try
            {
                con.Open();
                int count = command.ExecuteNonQuery();
                Label1.Text = "Updated " + count + " row"; 

            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping_170905004;Integrated Security=True";
            
            SqlCommand command = new SqlCommand("SELECT * from STAFF where StaffID=@StaffID", con);
            command.Parameters.AddWithValue("@StaffID", DropDownList1.SelectedItem.Text);
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds, "Staff_Details");
            
            //GridView1.DataSource = ds;
            //GridView1.DataBind();

            Label1.Text = "<b>" + "Details: " + "<br/>";
            foreach(DataColumn col in ds.Tables["Staff_Details"].Columns)
            {
                Label1.Text += col.ColumnName + "&emsp;&emsp;&ensp;";
            }

            Label1.Text += "</b>" + "<br/>";

            foreach(DataRow row in ds.Tables["Staff_Details"].Rows)
            {
                Label1.Text += row[0].ToString() + "&emsp;&emsp;&ensp;";
                Label1.Text += row[1].ToString() + "&emsp;&emsp;&ensp;";
                Label1.Text += row[2].ToString() + "&emsp;&emsp;&ensp;";
                Label1.Text += row[3].ToString() + "&emsp;&emsp;&ensp;";
                Label1.Text += row[4].ToString() + "&emsp;&emsp;&ensp;";
                Label1.Text += row[5].ToString() + "&emsp;&emsp;&ensp;";
                Label1.Text += row[6].ToString() + "&emsp;&emsp;&ensp;";
                Label1.Text += row[7].ToString() + "<br/>";
            }
            
        }
    }
}
