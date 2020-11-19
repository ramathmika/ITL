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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Products;Integrated Security=True";
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
            finally
            {
                con.Close();
            }
            
        }

        protected void textChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Products;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE Items SET price=@price where itemID=11", con);
                command.Parameters.AddWithValue("@price", TextBox1.Text);
                int count = command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Products;Integrated Security=True";
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
            finally
            {
                con.Close();
            }
        }
    }
}