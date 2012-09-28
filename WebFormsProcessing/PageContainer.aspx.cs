using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PageContainer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (System.Web.UI.Control item in Page.Controls)
        {
            if(item is LiteralControl)
            {
                Page.Response.Write(Server.HtmlEncode(((LiteralControl)item).Text) + "<br/>");
            }
            else
            {
                //System.Web.UI.Page pg = this;
                //pg.Page.Response.Write(item.ToString() + "<br />");
                DisplayControls(item, 1);
            }
        }
    }

    protected void DisplayControls(Control item, int depth)
    {
        if (item.Controls != null)
        {
            Page.Response.Write(new String('-', depth));
            Page.Response.Write(item.ToString() + "<br />");
            foreach (Control cntrl in item.Controls)
            {                
                DisplayControls(cntrl, depth++);               
            }            
        }
        else
        {
            Page.Response.Write(item.ToString() + "<br />");
        }       
    }
}