using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;

public partial class DefiningColumns : System.Web.UI.Page
{
    decimal total = 0;
    Label label2;
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        GridView.RowDataBound
        This event is raised when a part of the grid (the header, footer, or pager or a normal, alternate, or 
        selected item) is being created and bound to the data object. You can access the current row as a GridViewRow 
        control. The GridViewRow.DataItem property provides the data object for the given row, and the GridViewRow.Cells
        collection allows you to retrieve the row content. You can use the GridViewRow to change colors and
        alignment, add or remove child controls, and so on.
         */
        label2 = new Label();        
    }   
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedIndex = GridView1.SelectedIndex;
        int selectedDataKey = (int)GridView1.SelectedDataKey.Values["CategoryID"];

        //using column offset
        string categoryName = GridView1.SelectedRow.Cells[1].Text;       
        if(categoryName == "Beverages")
        {
            Label1.Text = "<i>" +"Verify age above 21 for rows marked in green" + "</i>";
        }        
    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string productName = (string)DataBinder.Eval(e.Row.DataItem, "ProductName");
            if (productName == "Wine")
            {
                e.Row.BackColor = Color.PaleGreen;
            }
        }
    }
    protected void GridView2_DataBound(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            foreach (GridViewRow item in GridView2.Rows)
            {
                string cost = (item.Cells[3].Text).Remove(0, 1);
                total += Decimal.Parse(cost) * Decimal.Parse(item.Cells[4].Text);
            }
            label2.Text = "Total stock price of the current category: $" + total.ToString();
        }
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        Page.Controls.Add(label2);
    }    
}