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

public partial class GridViewDemo : System.Web.UI.Page
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
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //reader.Read();
        //Label1.Text = reader.GetValue(1).ToString();
        //StringBuilder sb = new StringBuilder();
        //while (reader.Read())
        //{
        //    sb.Append(reader.GetValue(0));
        //    sb.Append(" ");
        //    sb.Append(reader["name"]);
        //    sb.Append("<br />");
        //}       
        GridView1.DataSource = reader;
        GridView1.DataBind();
        reader.Close();
        //con.Close();
    }
}