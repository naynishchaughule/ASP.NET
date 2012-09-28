using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Web.Configuration;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        Configuration config = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
        config.AppSettings.Settings["topic"].Value = "java";
        config.Save();               
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        byte[] arr = new byte[24];
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        rng.GetBytes(arr);
        System.Text.StringBuilder machineKey = new System.Text.StringBuilder(24);
        for (int i = 0; i < arr.Length; i++)
        {
            machineKey.Append(String.Format("{0:X2}", arr[i]));
        }
        Page.Response.Write(machineKey.ToString());



        Page.Response.Write(WebConfigurationManager.AppSettings["topic"] + "<br />");
        Page.Response.Write(WebConfigurationManager.ConnectionStrings["NorthwindConnection"] + "<br />");
        Page.Response.Write(WebConfigurationManager.GetSection("connectionStrings") + "<br />");
        CompilationSection cs = (CompilationSection)WebConfigurationManager.GetSection("system.web/compilation");
        foreach (AssemblyInfo item in cs.Assemblies)
        {
            Response.Write(item.Assembly + "<br /");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        OrderService obj = (OrderService)WebConfigurationManager.GetSection("OrderService");
        Page.Response.Write(obj.Location + "<br />");
        Configuration config = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
        ConfigurationSection s = config.GetSection("OrderService");
        Page.Response.Write(s.ElementInformation.Properties);
    }
}