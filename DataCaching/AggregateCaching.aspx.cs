using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AggregateCaching : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HelperAggregateCaching helper = new HelperAggregateCaching();        
        Cache["key1"] = "item in Cache at key 1";
        if(!Page.IsPostBack)
        {
            Cache.Insert("key2", "item in Cache at key 2", helper.GetAggregateDependency(HttpContext.Current)); 
        }
        Label1.Text = Cache["key2"].ToString();
    }
}