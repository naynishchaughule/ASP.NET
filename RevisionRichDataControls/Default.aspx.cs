using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string[] Friends = new string[] { "hi", "world", "hello"};
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public int GetIndex(object title)
    {
        return Array.IndexOf(Friends, title);
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        DropDownList list = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("DropDownList1");
        e.NewValues.Add("comments", list.SelectedValue);
    }
}