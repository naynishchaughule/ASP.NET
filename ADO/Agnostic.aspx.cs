using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;
using System.Web.Configuration;
using System.Data;

public partial class Agnostic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DbProviderFactory provider = DbProviderFactories.GetFactory(WebConfigurationManager.AppSettings["factory"]);
        DbConnection con = provider.CreateConnection();
        con.ConnectionString = WebConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
        DbCommand cmd = provider.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = WebConfigurationManager.AppSettings["sampleQuery"];
        cmd.Connection = con;
        con.Open();
        DbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        Label1.Text = "";
        while (reader.Read())
        {
            Label1.Text += reader.GetValue(0);
            Label1.Text += " ";
            Label1.Text += reader.GetValue(1);
            Label1.Text += "<br />";
        }
        reader.Close();
    }
}