using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWebService;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MyWebService.SoapSerialization sz = new SoapSerialization();
        Diving div = new Diving();
        div = sz.Display(20, 30);
        Page.Response.Write(div.x + " " + div.y);
    }
}