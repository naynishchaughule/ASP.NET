using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Web.UI.Control
        foreach (Control item in Page.Controls)
        {
            //Page.FindControl("Button1").Visible = false;
            Page.Response.Write(item.ClientID);            
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Page.Response.Write("btnSubmit_Click, HtmlServer control");
    }
}