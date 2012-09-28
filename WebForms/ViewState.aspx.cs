using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewState : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack)
        {
            string viewStateString = Page.Request.Form["__VIEWSTATE"];
            byte[] viewArr = Convert.FromBase64String(viewStateString);
            string decodedViewState = System.Text.Encoding.ASCII.GetString(viewArr);
            Label2.Text = decodedViewState;
        }
    }

    protected void CheckBox1_Checked(object sender, EventArgs e)
    {
        Label1.Text = "CheckBox1_Checked";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Label3.Text = "Button2_Click";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Label3.Text = "Button3_Click";
    }
}