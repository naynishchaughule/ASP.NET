using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdvancedGrids : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        
    }
    protected void GridView1_DataBound(object sender, EventArgs e)
    {
        decimal total = 0;
        decimal unitPrice;
        int unitsInStock;
        foreach (GridViewRow item in GridView1.Rows)
        {
            unitPrice = Decimal.Parse(item.Cells[3].Text);
            unitsInStock = Int32.Parse(item.Cells[4].Text);
            total += unitPrice * unitsInStock;
        }
        GridViewRow footer = GridView1.FooterRow;
        footer.Cells[3].ColumnSpan = 2;
        footer.Cells.RemoveAt(4);
        footer.HorizontalAlign = HorizontalAlign.Left;
        footer.Cells[3].Text = "Total Stock Price: " + total.ToString();
    }
}