using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ValidationGroup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach (BaseValidator item in Page.GetValidators("Group1"))
        {
            Page.Response.Write(item.ControlToValidate);
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        foreach (BaseValidator item in Page.GetValidators("Group2"))
        {
            Page.Response.Write(item.ControlToValidate);            
        }
    }
}