using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ItemRemovedCallBack : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Cache.Insert("key1", "item in Cache at key1", new System.Web.Caching.CacheDependency(Server.MapPath("test1")), DateTime.Now.AddDays(1), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, new System.Web.Caching.CacheItemRemovedCallback(MyCallBackMethod));
        Cache.Remove("key1");
    }

    public void MyCallBackMethod(string s, object obj, System.Web.Caching.CacheItemRemovedReason reason)
    {
        Label1.Text = "MyCallBackMethod " + reason.ToString();        
    }
}