using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListControlDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = DropDownList1.SelectedItem.Value;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("naynish", "chaughule");
        dictionary.Add("tripti", "panjabi");
        dictionary.Add("purab", "bhatt");
        DropDownList1.DataSource = dictionary;
        Page.DataBind();
    }
}