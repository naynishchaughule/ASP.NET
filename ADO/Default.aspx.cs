using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void  Button1_Click(object sender, EventArgs e)
    {
        //string connectionString = @"Data Source=localhost\sqlexpress; Initial Catalog=Northwind; Integrated Security=SSPI";
        string webConfigConnectionString = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

        //string userInstanceConnectionString = @"Data Source=localhost\sqlexpress;" +
        //                                      "Integrated Security=SSPI;" +
        //                                      @"AttachDBFilename=DataDirectory\UserInstanceDB.mdf;User Instance=True";

        SqlConnection con = new SqlConnection();
        con.ConnectionString = webConfigConnectionString;
        try
        {            
            con.Open();
            Label1.Text = "Server Version: " + con.ServerVersion + "<br />";
            Label1.Text += "State: " + con.State.ToString() + "<br />";
        }
        catch (Exception error)
        {
            Label1.Text = "Error Message: " + error.Message + "<br />";
        }
        finally
        {
            con.Close();
            Label1.Text += "State: " + con.State.ToString();
        }
    }
}