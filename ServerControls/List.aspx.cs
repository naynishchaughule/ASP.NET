using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            List<string> myList = new List<string>();
            myList.Add("--select subject--");
            myList.Add("component based enterprise software development");
            myList.Add("advanced software paradigm");
            DropDownList1.DataSource = myList;
            DropDownList1.DataBind();
            DropDownList1.AutoPostBack = true;
            CheckBoxList1.RepeatLayout = RepeatLayout.Flow;
            CheckBoxList1.Items.Add("fall");
            CheckBoxList1.Items.Add("spring");
            CheckBoxList1.Items.Add("summer");
            //CheckBoxList1.RepeatDirection = RepeatDirection.Horizontal;
            CheckBoxList1.RepeatColumns = 2;
            //CheckBoxList1.CellSpacing = 200;
            //CheckBoxList1.CellPadding = 200;
            CheckBoxList1.TextAlign = TextAlign.Right;
        }
        DropDownList1.SelectedIndexChanged += new EventHandler(DropDownList1_SelectedIndexChanged);
    }

    void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Page.Response.Write(((DropDownList)sender).SelectedIndex);
        //Page.Response.Write(((DropDownList)sender).SelectedItem);
    }
}