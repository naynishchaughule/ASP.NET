using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Procedure : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
        //con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "InsertSampleData";
        cmd.Connection = con;
        cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4));
        cmd.Parameters["@Id"].Value = 27492;
        //cmd.Parameters["@Id"].Direction = ParameterDirection.Output;

        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 20));
        cmd.Parameters["@Name"].Value = "purab bhatt";

        con.Open();
        cmd.ExecuteNonQuery();
        Page.Response.Write(cmd.Parameters["@Id"].Value);
        con.Close();
    }
}