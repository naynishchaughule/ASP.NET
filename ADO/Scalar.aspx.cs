using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Text;

public partial class Scalar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress; Initial Catalog=Northwind; Integrated Security=SSPI;");
        con.Open();
        SqlCommand cmd = new SqlCommand("select Count(*) from SampleData", con);
        int count = (int)cmd.ExecuteScalar();
        Page.Response.Write(count);
        SqlCommand cmdInsert = new SqlCommand("insert into SampleData values (78201, 'purab bhatt')", con);
        Page.Response.Write("Rows affected " + cmdInsert.ExecuteNonQuery());
        con.Close();
    }
}