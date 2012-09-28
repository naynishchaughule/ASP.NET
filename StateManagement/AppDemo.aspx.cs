using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AppDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //int count = 0;
        //Application.Lock();
        //count = (int)Application["counter"];
        //count++;
        //Application["counter"] = count;
        //Application.UnLock();
        string[] arr = new string[2];
        arr = ASP.global_asax.Global.FileList;
        arr[0] = "naynish";
        arr[1] = "gwu";        
    }
}