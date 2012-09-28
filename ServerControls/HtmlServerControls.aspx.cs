using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HtmlServerControls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Text1.Attributes["id"] = "hello";
        Page.Response.Write(Text1.Attributes["id"] + "<br />");       
        Text1.Attributes["onfocus"] = "alert(\"javascript failure\")";
        //Text1.Disabled = true;
        Page.Response.Write(Text1.Style["color"] + "<br />");
        Page.Response.Write(Text1.TagName + "<br />");
        //Div1.InnerHtml = "<b>hello world!</b>";
        //Div1.InnerText = "<b>hello world!</b>";
        Page.Response.Write(Text1.Type);
    }
}