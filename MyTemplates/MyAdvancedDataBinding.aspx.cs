using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyAdvancedDataBinding : System.Web.UI.Page
{
    public string[] Prefix
    {
        get
        {
            return new string[] { "Mr.", "Ms."};
        }
    }
    protected int GetSelectedTitle(object title)
    {
        return Array.IndexOf(Prefix, title.ToString());
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        DropDownList title = (DropDownList)(GridView1.Rows[e.RowIndex].FindControl("DropDownList1"));
        e.NewValues.Add("TitleOfCourtesy", title.Text);
    }
}