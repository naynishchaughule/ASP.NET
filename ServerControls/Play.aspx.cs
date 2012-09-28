using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;

public partial class Play : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Response.Write(Page.FindControl("Button1").ClientID + "<br />");
        Recursion(Page);
        Page.Response.Write(Button1.EnableViewState + "<br />");
        Page.Response.Write(Page.FindControl("Label1").Parent + "<br />");
        //Button1.Visible = false;    
        List<string> myList = new List<string>();
        myList.Add("naynish"); myList.Add("tripti");
        ListBox1.DataSource = myList;
        ListBox1.DataBind();        
    }

    protected void Recursion(Control cntrl)
    {
        foreach (Control item in cntrl.Controls)
        {
            if (item.HasControls())
            {
                Recursion(item);
            }
            else
            {
                Page.Response.Write(item + "<br />");
            }
        }
    }
}