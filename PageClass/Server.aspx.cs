using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Server : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Web.HttpServerUtility
        Page.Response.Write(Page.Server.MachineName + "<br />");
        Page.Response.Write(Page.Server.GetLastError() + "<br />");
        string s = "<b>Hello World!</b>";
        Page.Response.Write(s + "<br />");
        Page.Response.Write(Server.HtmlEncode(s) + "<br />");
        Page.Response.Write(Server.HtmlDecode(s) + "<br />");
        string url = "http://localhost:1895/PageClass/Server.aspx";
        Page.Response.Write(Server.UrlEncode(url) + "<br />");
        Page.Response.Write(Server.UrlDecode(url) + "<br />");
        Page.Response.Write(Server.MapPath("~/Default.aspx") + "<br />");

        Page.Response.Write(Page.User.Identity.Name + "<br />");        
    }
}