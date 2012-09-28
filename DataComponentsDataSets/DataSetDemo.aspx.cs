using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;

public partial class DataSetDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["Nash"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Employees";
        cmd.Connection = con;

        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;

        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet, "Employees");

        StringBuilder builder = new StringBuilder();
        foreach (DataRow item in dataSet.Tables["Employees"].Rows)
        {
            builder.Append(item["EmployeeID"].ToString());
            builder.Append(" ");
            builder.Append(item["FirstName"].ToString());
            builder.Append(" ");
            builder.Append(item["LastName"].ToString());
            builder.Append(" ");
            builder.Append(item["TitleOfCourtesy"].ToString());
            builder.Append("<br />");
        }
        Page.Response.Write(builder);
    }
}