using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Read
        Employee emp1 = (Employee)ConfigurationManager.GetSection("Employee");  
        Page.Response.Write(emp1.Id + "<br />");

        //Write
        Configuration config = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
        ConfigurationSection csc = config.GetSection("Employee");
        csc.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
        foreach (PropertyInformation item in csc.ElementInformation.Properties)
        {
            if (item.Name == "Id")
                item.Value = 48090;
            Page.Response.Write(item.Value);    
        }
        config.Save();
    }
}