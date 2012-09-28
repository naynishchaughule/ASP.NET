using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {        
        lblInfo.Text += "Page_Init";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            lblInfo.Text = "Page_Load, Initial Request";
        }
        else if (Page.IsPostBack)
        {
            lblInfo.Text += "<br>" + "Page_Load, PostBack";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lblInfo.Text += "<br>" + "Button1_Click";
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        lblInfo.Text += "<br>" + "Page_PreRender";
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        lblInfo.Text += "<br>" + "Page_Unload";
    }   
}