using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class LinqToDataSet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Products";
        cmd.Connection = con;
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        DataSet dataSet = new DataSet();
        try
        {
            con.Open();
            adapter.Fill(dataSet, "Products");
        }
        catch (Exception)
        {
            throw new ApplicationException("Data error");
        }
        var result = from item in dataSet.Tables["Products"].AsEnumerable()
                     where item.Field<decimal>("UnitPrice") > 5
                     select item;          
        GridView1.DataSource = result.AsDataView();
        GridView1.DataBind();
    }
}