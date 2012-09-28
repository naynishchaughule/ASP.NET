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
        System.Web.UI.Page page = Page;
        //System.Web.SessionState.HttpSessionState
        page.Session.Add("48090", "naynish p. chaughule");
        foreach (var item in page.Session.Keys)
	    {
		    if(item.ToString() == "48090")
            {
                Page.Response.Write(item + "<br />");
            }
	    }

        //System.Web.HttpApplicationState
        Page.Application.Add("65985", "tripti panjabi");
        foreach (var item1 in Page.Application.Keys)
        {
            if(item1.ToString() == "65985")
            {
                Page.Response.Write(item1);
            }
        }

        //System.Web.Caching.Cache
        //todo: need to implement


        //virtual directory
        Page.Response.Write("<br />" + Page.Request.ApplicationPath);
        Page.Response.Write("<br />" + Page.Request.PhysicalApplicationPath);

        Page.Response.Write("<br />" + Page.Request.Browser.ActiveXControls);
        Page.Response.Write("<br />" + Page.Request.ClientCertificate.IsPresent);
        Page.Response.Write("<br />" + Page.Request.FilePath);
        Page.Response.Write("<br />" + Page.Request.CurrentExecutionFilePath);

        Page.Response.Write("<br />" + Page.Request.IsLocal);
        Page.Response.Write("<br />" + Page.Request.Url);
        Page.Response.Write("<br />" + Page.Request.UserHostAddress);
        Page.Response.Write("<br />" + Page.Request.UserHostName);


        foreach (string item in Page.Request.UserLanguages)
	    {
		    Page.Response.Write("<br />" + item);         
	    }

        string name = Page.Request.Form["TextBox1"];
        Page.Response.Write("<br />" + Page.Request.UserAgent);        
        Page.Response.Write("<hr />" + name);


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("~/Transfer.aspx");
    }
}
