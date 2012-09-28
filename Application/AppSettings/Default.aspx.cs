using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Page.Response.Write(WebConfigurationManager.AppSettings["Id"] + "<br />");
            Page.Response.Write(WebConfigurationManager.ConnectionStrings["NashConnection"] + "<br />");
            CompilationSection csn = (CompilationSection)WebConfigurationManager.GetSection("system.web/compilation");
            Page.Response.Write(csn.TargetFramework + "<br />");

            CompilationSection assembliesSection = (CompilationSection)WebConfigurationManager.GetSection("system.web/compilation");
            foreach (AssemblyInfo item in assembliesSection.Assemblies)
            {
                Page.Response.Write(item.Assembly + "<br />");
            }
            Page.Response.Write("<hr />");
            Configuration configObject = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
            AppSettingsSection appSettingsSection = (AppSettingsSection)configObject.GetSection("appSettings");
            appSettingsSection.Settings["Id"].Value = "65985";
            Page.Response.Write(appSettingsSection.Settings["Id"].Value);
            configObject.Save(ConfigurationSaveMode.Full);            
        }
        Product prod = (Product)WebConfigurationManager.GetSection("product"); 
        Page.Response.Write("<hr />");
        Page.Response.Write(prod.id);

        //open
        Configuration cnfg = (Configuration)WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
        Product prod1 = (Product)cnfg.GetSection("product");
        //modify
        prod1.name = "mouse";
        cnfg.Save();
        Response.Write("<hr />");
        Response.Write(prod.name);
    }
}