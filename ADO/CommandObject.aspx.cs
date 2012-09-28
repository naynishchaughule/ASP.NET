using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Text;

public partial class CommandObject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string webConfig = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        SqlConnection con = new SqlConnection(webConfig);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from dbo.SampleData";
        cmd.Connection = con;
        //SqlCommand cmd = new SqlCommand("select * from SampleData", con);
        SqlDataReader reader = cmd.ExecuteReader();
        //reader.Read();
        //Label1.Text = reader.GetValue(1).ToString();
        StringBuilder sb = new StringBuilder();
        while (reader.Read())
        {
            sb.Append(reader.GetValue(0));
            sb.Append(" ");
            sb.Append(reader["name"]);
            sb.Append("<br />");
        }
        Label1.Text = sb.ToString();
        reader.Close();
        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string webConfig = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        SqlConnection con = new SqlConnection(webConfig);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from SampleData; select * from dbo.NullData";
        cmd.Connection = con;
        //SqlCommand cmd = new SqlCommand("select * from SampleData", con);
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //reader.Read();
        //Label1.Text = reader.GetValue(1).ToString();
        StringBuilder sb = new StringBuilder();
        do
        {
            while (reader.Read())
            {
                if (reader.GetValue(0) == DBNull.Value)
                {
                    sb.Append("null value");
                }
                else
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        sb.Append(reader.GetValue(i));
                        sb.Append(" ");                        
                    }
                    sb.Append("<br />"); 
                }
            } 
        } while (reader.NextResult());
        Label2.Text = sb.ToString();
        reader.Close();
    }
}