using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace sample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=dbo.sales;Integrated Security=True";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT DISTINCT sales_id from sales", con);
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                        DropDownList1.Items.Add(reader["sales_id"].ToString());
                }
                catch(Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void idSelected(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=dbo.sales;Integrated Security=True";
            SqlCommand command = new SqlCommand("SELECT item_name, item_amt, quantity FROM sales where sales_id=@sales_id", con);
            command.Parameters.AddWithValue("@sales_id", DropDownList1.SelectedItem.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(ds, "sales_details");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            
        }
    }
}