using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bullet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BulletedList1.Items.Add("java");
        BulletedList1.Items.Add("c#");
        BulletedList1.BulletStyle = BulletStyle.CustomImage;
        BulletedList1.BulletImageUrl = "firefox2005-icon.png";
        BulletedList1.DisplayMode = BulletedListDisplayMode.LinkButton;
    }
}