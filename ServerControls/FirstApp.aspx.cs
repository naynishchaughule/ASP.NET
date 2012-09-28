using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FirstApp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Handler(object sender, EventArgs e)
    {
        ListBox1.Items.Add(((Control)sender).GetType().Name + "  " + e.ToString());
    }

    protected void Handler_Image(object sender, EventArgs e)
    {
        Page.Response.Write(((ImageClickEventArgs)e).X.ToString() + " " + ((ImageClickEventArgs)e).Y.ToString());
    }
}