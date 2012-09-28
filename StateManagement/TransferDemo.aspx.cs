using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TransferDemo : System.Web.UI.Page
{
    int Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Id = 48090;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("GetData.aspx?EmployeeId=" + Id.ToString() + "&Name=naynish p. chaughule" + "&Organization=" + Server.UrlEncode("nash & sons"));        
    }
}