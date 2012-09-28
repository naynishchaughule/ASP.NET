using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class AdvancedFiltering : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Nash"].ConnectionString);
        SqlCommand cmd = new SqlCommand("select * from Categories", con);
        SqlCommand cmd1 = new SqlCommand("select * from Products", con);
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        DataSet dataSet = new DataSet();
        con.Open();
        adapter.Fill(dataSet, "Categories");
        adapter.SelectCommand = cmd1;
        adapter.Fill(dataSet, "Products");
        con.Close();
        DataRelation relation = new DataRelation("primary", dataSet.Tables["Categories"].Columns["CategoryID"], dataSet.Tables["Products"].Columns["CategoryID"]);
        dataSet.Relations.Add(relation);

        DataColumn column1 = new DataColumn("no. of products", typeof(int), "Count(Child(primary).CategoryID)");
        dataSet.Tables["Categories"].Columns.Add(column1);
        GridView1.DataSource = dataSet;
        GridView1.DataBind();

        //DataView view = new DataView(dataSet.Tables["Categories"]);
        //view.RowFilter = "Count(Child(primary).CategoryID) > 1";

        //GridView1.DataSource = view;    
        //GridView1.DataBind();

        //GridView1.DataSource = dataSet;
        //GridView1.DataMember = "Categories";
        //GridView1.DataBind();
    }
}