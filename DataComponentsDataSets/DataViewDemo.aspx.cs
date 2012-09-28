using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class DataViewDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["Nash"].ConnectionString;
        SqlConnection connectionObj = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select * from Employees where EmployeeID=@EmployeeID";
        cmd.CommandText = "select * from Employees";
        cmd.Connection = connectionObj;
        SqlParameter param1 = new SqlParameter();
        //param1.ParameterName = "@EmployeeID";
        param1.SqlDbType = SqlDbType.Int;
        param1.Size = 4;
        //cmd.Parameters.Add(param1);
        //try
        //{
        //    cmd.Parameters["@EmployeeID"].Value = Convert.ToInt32(TextBox1.Text);
        //}
        //catch (Exception error)
        //{
        //    Page.Response.Write(error.Message.ToString());
        //}
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;        
        DataSet dataSet = new DataSet();
        try
        {
            connectionObj.Open();
            adapter.Fill(dataSet, "Employees");
            connectionObj.Close();
        }
        catch (Exception)
        {
            Page.Response.Write("Data error");
        }

        //GridView1.DataSource = dataSet;
        //GridView1.DataMember = "Employees";
        //GridView1.DataBind();

        //DataView view = new DataView(dataSet.Tables["Employees"]);
        //view.Sort = "FirstName, LastName";
        //GridView1.DataSource = view;
        //GridView1.DataBind();
        DataView view = new DataView(dataSet.Tables["Employees"]);
        view.Sort = "EmployeeID";
        view.RowFilter = "EmployeeID > 50000";
        GridView1.DataSource = view;
        GridView1.DataBind();
    }
}