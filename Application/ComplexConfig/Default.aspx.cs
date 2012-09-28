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
        Employee emp = (Employee)WebConfigurationManager.GetSection("employee");
        Page.Response.Write(emp.personal.fname + "<br />");

        Configuration cnfg = (Configuration)WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
        Employee emp1 = (Employee)cnfg.GetSection("employee");
        emp1.personal.fname = "tripti";
        cnfg.Save();
        Page.Response.Write(emp1.personal.fname + "<br />");

        //encrypt the employee section
        Configuration encrypt = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
        Employee emp2 = (Employee)encrypt.GetSection("employee");
        emp2.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
        encrypt.Save();
    }
}