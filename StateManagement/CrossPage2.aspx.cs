using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CrossPage2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if(PreviousPage != null)
        //{
        //    Page.Response.Write(PreviousPage.Header.Title);
        //}
        CrossPage1 prevPage = PreviousPage as CrossPage1;
        if(prevPage != null)
        {
            Page.Response.Write(prevPage.TextName);
        }
        Page.Response.Write(Request["txtAge"]);
    }
}