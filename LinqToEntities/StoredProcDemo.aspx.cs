using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NorthwindModel;

public partial class StoredProcDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NorthwindEntities objectContext = new NorthwindEntities();
        var result = objectContext.SelectCategory(65985);
        GridView1.DataSource = result;
        GridView1.DataBind();
    }
}