using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Params : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from SampleData where Id = @Id", con))
                {
                    SqlParameter param1 = new SqlParameter("@Id", TextBox1.Text);
                    cmd.Parameters.Add(param1);
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                }
            }
        }
        catch (Exception error)
        {
            Page.Response.Write("Error on page");
        }
    }
}