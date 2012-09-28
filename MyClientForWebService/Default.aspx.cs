using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Basics.Service ser = new Basics.Service();
        GridView1.DataSource = ser.GetProducts(601222);
        GridView1.DataBind();        
    }
}