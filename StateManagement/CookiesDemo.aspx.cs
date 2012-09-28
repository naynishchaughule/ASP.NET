using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CookiesDemo : System.Web.UI.Page
{    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            HttpCookie cookie = new HttpCookie("UserDetails");
            cookie.Expires = DateTime.Now.AddYears(1);
            cookie["Id"] = "48090";
            cookie["Name"] = "naynish";
            //deleting the cookie
            //cookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie);     
        }
    }
    protected void Display_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["UserDetails"];
        if(cookie != null)
        Label1.Text = cookie["name"] + " " + cookie["Id"];
    }
    protected void Create_Click(object sender, EventArgs e)
    {
      
    }
}