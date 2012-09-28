using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class SqlDependency : System.Web.UI.Page
{    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            System.Data.SqlClient.SqlDependency.Start(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select CategoryID, ProductID, ProductName, UnitPrice, UnitsInStock from dbo.Products";
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            SqlCacheDependency dependency = new SqlCacheDependency(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Products");
            Cache.Insert("key1", dataSet, dependency);
        }
        Label1.Text = Cache["key1"].ToString();
    }   
}