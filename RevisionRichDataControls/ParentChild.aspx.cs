using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ParentChild : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_DataBound(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            GridView gridChild = (GridView)e.Row.Cells[1].FindControl("GridView2");
            string catID = GridView1.DataKeys[e.Row.DataItemIndex].Value.ToString();
            SqlDataSource2.SelectParameters[0].DefaultValue = catID;            
            object data = SqlDataSource2.Select(DataSourceSelectArguments.Empty);
            gridChild.DataSource = data;
            gridChild.DataBind();
        }
    }
}