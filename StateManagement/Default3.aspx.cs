using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(PreviousPage != null)
        {
            if (PreviousPage.IsValid)
            {

            }
            else
            {
                Response.Redirect(Request.UrlReferrer.AbsolutePath+ "?error=true");
            }
        }
    }
}