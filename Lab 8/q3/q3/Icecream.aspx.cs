using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace q3
{
    public partial class Icecream : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Products_170905004;Integrated Security=True";

                try
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("SELECT price FROM Items WHERE itemID=11", con);

                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Label1.Text = reader["price"].ToString();
                    }
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
            
        }

        //protected void textChanged(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Products_170905004;Integrated Security=True";
        //    try
        //    {
        //        con.Open();
                
        //        SqlCommand command = new SqlCommand("UPDATE Items SET price=@price where itemID=11", con);
        //        command.Parameters.AddWithValue("@price", TextBox1.Text);
                
        //        int count = command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        Label1.Text = ex.Message;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Products;Integrated Security=True";
            try
            {
                con.Open();
                
                SqlCommand command = new SqlCommand("UPDATE Items SET price=@price where itemID=11; SELECT price FROM Items WHERE itemID=11", con);
                command.Parameters.AddWithValue("@price", TextBox1.Text);

                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Label1.Text = reader["price"].ToString();
                }
                TextBox1.Text = "";
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
    }
}