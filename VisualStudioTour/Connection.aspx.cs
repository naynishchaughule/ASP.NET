using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Connection : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSubmit.Click += new EventHandler(btnSubmit_Click);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Page.Response.Write("Wire-up");
    }   
}