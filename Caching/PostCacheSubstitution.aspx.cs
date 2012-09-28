using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PostCacheSubstitution : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Static Data: " +  DateTime.Now.ToString();
        Page.Response.WriteSubstitution(new HttpResponseSubstitutionCallback(GetDynamicContent));
    }
    protected static string GetDynamicContent(HttpContext context)
    {        
        string dyn = "Dynamic Data: " + DateTime.Now.ToString();        
        return dyn;
    }
}