using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HtmlControls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            Text1.Style["font-size"] = "20px";
            Text1.Style["color"] = "blue";
            Text1.Style.Add("background-color", "lightyellow");
            Text1.Value = "<enter email-address here>";
            Text1.Attributes["onfocus"] = "alert(Text1.Value)";
        }
    }
}