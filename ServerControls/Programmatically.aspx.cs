using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Programmatically : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlTable myTable = new HtmlTable();
        myTable.Border = 1;
        myTable.CellPadding = 3;
        myTable.CellSpacing = 3;        

        for (int i = 0; i < 3; i++)
        {
            HtmlTableRow myRow = new HtmlTableRow();
            for (int j = 0; j < 4; j++)
            {
                HtmlTableCell myCell = new HtmlTableCell();
                myCell.InnerHtml = i + ", " + j;
                myRow.Cells.Add(myCell);                
            }
            myTable.Rows.Add(myRow);
        }
        Page.Controls.Add(myTable);
    }
}