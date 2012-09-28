using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class DataViewBinding : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["nashNorthwind"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Employees", con);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;            
            try
            {
                adapter.Fill(dataSet, "Employees");
                DataView view = new DataView(dataSet.Tables["Employees"]);
                view.RowFilter = "EmployeeID > 50000";
                GridView1.DataSource = view;
                GridView1.DataBind();
            }
            catch (Exception)
            {
                throw new ApplicationException("Data error");
            }
        }
    }
}