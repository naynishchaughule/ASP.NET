using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class ReaderBinding : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["nashNorthwind"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT EmployeeID, TitleOfCourtesy + ' ' + " + "FirstName + ' ' + LastName As FullName FROM Employees";

            cmd.Connection = con;

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                ListBox1.DataSource = reader;
                ListBox1.DataBind();
                reader.Close();
            }
            catch (Exception)
            {
                throw new ApplicationException("Data error");
            } 
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Selected)
                Label1.Text = item.Value;
        }
    }
}