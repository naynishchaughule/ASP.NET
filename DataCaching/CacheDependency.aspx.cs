using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CacheDependency : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DependencyDemo demo = new DependencyDemo();

        //if (!Page.IsPostBack)
        //{
        //    Cache.Insert("key1", "cache item 1", demo.GetCacheDependencyInstance(HttpContext.Current), DateTime.Now.AddSeconds(30), TimeSpan.Zero);         
        //}
        //Label1.Text = Cache["key1"].ToString();

        Cache["key1"] = "Cache Item 1";
        Cache.Insert("key2", "Cache Item 2", demo.GetCacheDependencyInstance(HttpContext.Current), DateTime.Now.AddSeconds(30), TimeSpan.Zero);
        Cache.Remove("key1");
        Label1.Text = Cache["key2"].ToString();
    }
}