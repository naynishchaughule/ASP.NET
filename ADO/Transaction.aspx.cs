using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Transaction : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "update SampleAccount set Balance = Balance - @Amount where Id='A'";
        cmd1.Connection = con;
        cmd1.Parameters.Add(new SqlParameter("@Amount", Convert.ToInt32(TextBox1.Text)));

        SqlCommand cmd2 = new SqlCommand("update SampleAccount set Balance = Balance + @Amount where Id='B'", con);
        cmd2.Parameters.Add(new SqlParameter("@Amount", Convert.ToInt32(TextBox1.Text)));
        SqlTransaction trans = null;

        try
        {
            con.Open();
            trans = con.BeginTransaction();
            cmd1.Transaction = trans;            
            cmd1.ExecuteNonQuery();
            trans.Save("nash");
            throw new ApplicationException();
            cmd2.Transaction = trans;            
            cmd2.ExecuteNonQuery();
            trans.Commit();
            Page.Response.Write("Success");
        }
        catch (Exception)
        {
            trans.Rollback("nash");
            Page.Response.Write("Fail");
            trans.Commit();
        }
        finally
        {
            con.Close();
        }
    }
}