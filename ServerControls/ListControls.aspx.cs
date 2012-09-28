using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListControls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ListBox1.Items.Add("program 1");
            DropDownList1.Items.Add("program 1");
            CheckBoxList1.Items.Add("program 1");
            RadioButtonList1.Items.Add("program 1");
        }
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Selected)
            {
                Page.Response.Write(item);
            }
        }
    }
}