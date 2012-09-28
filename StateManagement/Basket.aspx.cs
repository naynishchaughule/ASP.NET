using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Basket : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Amazon"] = "IPhone";
        Page.Response.Write(Session.SessionID);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Label1.Text = Session["Amazon"].ToString();
        Response.Redirect("Checkout.aspx");
    }
}