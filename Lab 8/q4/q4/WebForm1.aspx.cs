using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Company;Integrated Security=True";
            SqlCommand com = new SqlCommand("INSERT INTO Works(person_name, company_name, salary) VALUES(@name, @company, @salary); INSERT INTO LIVES(person_name, street, city) VALUES(@name, @street, @city)", con);
            com.Parameters.AddWithValue("@name", TextBox1.Text);
            com.Parameters.AddWithValue("@company", TextBox2.Text);
            com.Parameters.AddWithValue("@salary", TextBox3.Text);
            com.Parameters.AddWithValue("@street", TextBox4.Text);
            com.Parameters.AddWithValue("@city", TextBox5.Text);

            try
            {
                con.Open();
                com.ExecuteNonQuery();
                Label2.Text = "Record successfuly iInserted";
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Company;Integrated Security=True";
            SqlCommand com = new SqlCommand("SELECT L.person_name, city FROM Works W, Lives L where W.person_name=L.person_name and W.company_name = @company", con);
            com.Parameters.AddWithValue("@company", TextBox6.Text);
            SqlDataReader reader;

            try
            {
                con.Open();
                reader = com.ExecuteReader();
                Label1.Text = "Details of employees working in " + TextBox6.Text + " are: " + "<br/>";
                while (reader.Read())
                {
                    Label1.Text += reader["person_name"] + " lives in " + reader["city"] + "<br/>";
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}