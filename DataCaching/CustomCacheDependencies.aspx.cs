using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomCacheDependencies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
        TimerTestCacheDependency dep = new TimerTestCacheDependency();
        Cache.Insert("key1", "item at key1", dep);
    }
}