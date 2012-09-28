using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected int x;
    protected void Page_Load(object sender, EventArgs e)
    {
        x = 10;
        Page.DataBind();
    }

    protected int GetValue()
    {
        return x;
    }
}