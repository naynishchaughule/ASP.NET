using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Concurrency : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        if(e.AffectedRows == 0)
        {
            e.KeepInEditMode = true;
            DetailsView1.DataBind();
            TextBox txt;
            txt = (TextBox)DetailsView1.Rows[2].Cells[1].Controls[0];
            txt.Text = (string)e.NewValues["ProductName"];
            txt = (TextBox)DetailsView1.Rows[3].Cells[1].Controls[0];
            txt.Text = (string)e.NewValues["UnitPrice"];
            txt = (TextBox)DetailsView1.Rows[4].Cells[1].Controls[0];
            txt.Text = (string)e.NewValues["UnitPrice"];
            Panel1.Visible = true;
        }
    }
    protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {
        if (!Panel1.Visible) e.Cancel = true;
    }
    protected int ProductIDForSource2()
    {
        return Convert.ToInt32(DetailsView1.Rows[1].Cells[1].Text);
    }
}