using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Response.Write(Page.Request.QueryString["EmployeeId"] + " " + Request.QueryString["Name"]
            + " " + Request.QueryString["Organization"]);
    }
}