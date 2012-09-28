using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewStateDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            Label1.Text = "Initial Request";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Clicked";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {        
        Label1.Page.RegisterRequiresViewStateEncryption();
    }
}