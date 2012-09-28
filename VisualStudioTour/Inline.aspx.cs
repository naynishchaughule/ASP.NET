using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inline : System.Web.UI.Page
{
    protected int x = 10;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = "Load event";
    }
}