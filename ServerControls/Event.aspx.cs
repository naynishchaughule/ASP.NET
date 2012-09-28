using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Event : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            Select1.Items.Add("view");
            Select1.Items.Add("profile");
            Select1.Items.Add("admin");
        }
    }

    protected void Ctrl_ServerChange(object sender, EventArgs e)
    {
        Response.Write("<ul><li>ServerChange detected for " + ((Control)sender).ID + "</li></ul>");                        
    }

    protected void Select1_ServerChange(object sender, System.EventArgs e)
    {
        Response.Write("<ul><li>ServerChange detected for List1. " +
        "The selected items are:</li><ul>");
        foreach (ListItem li in Select1.Items)
        {
            if (li.Selected)
                Response.Write("<li>" + li.Value + "</li>");
        }
        Response.Write("</ul></ul>");
    }

    protected void Submit1_ServerClick(object sender, System.EventArgs e)
    {
        Response.Write("<ul><li>ServerClick detected for Submit1.</li></ul>");
    }
}