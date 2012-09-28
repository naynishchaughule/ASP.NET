using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = GridView1.SelectedIndex;
        int ID = (int)GridView1.SelectedDataKey.Values["EmployeeID"];
        string fname = GridView1.SelectedRow.Cells[2].Text;
        string lname = GridView1.SelectedRow.Cells[3].Text;

        Label1.Text = index + " " + ID + " " + fname + " " + lname;
    }
}