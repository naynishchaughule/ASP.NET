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

public partial class AdvancedDataSet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Nash"].ConnectionString);
        SqlCommand cmd1 = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories", connection);
        SqlCommand cmd2 = new SqlCommand("SELECT ProductName, CategoryID FROM Products", connection);

        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd1;

        DataSet dataSet = new DataSet();
        try
        {
            connection.Open();
            adapter.Fill(dataSet, "Categories");
            adapter.SelectCommand = cmd2;
            adapter.Fill(dataSet, "Products");
        }
        catch (SqlException)
        {
            throw new ApplicationException("Data error");
        }
        finally
        {
            connection.Close();
        }

        DataRelation relations = new DataRelation("PrimaryCategories-ForeignProducts", dataSet.Tables["Categories"].Columns["CategoryID"], dataSet.Tables["Products"].Columns["CategoryID"]);
        dataSet.Relations.Add(relations);
        dataSet.EnforceConstraints = true;
        StringBuilder builder = new StringBuilder();
        foreach (DataRow item in dataSet.Tables["Categories"].Rows)
        {
            foreach(DataRow product in item.GetChildRows(relations))
            {
                builder.Append(product["CategoryID"]);
                builder.Append(" ");
                builder.Append(product["ProductName"]);
                builder.Append("<br />");
            }
        }
        Page.Response.Write(builder);

        foreach (DataRow item in dataSet.Tables["Categories"].Select("CategoryName = 'Books'"))
        {
            Page.Response.Write("<br />" + item["CategoryId"] + " " + item["CategoryName"]);
        }

        GridView1.DataSource = dataSet;
        GridView1.DataMember = "Categories";
        //GridView1.DataBind();
        Page.DataBind();
    }
}