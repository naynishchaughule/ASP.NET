using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //GridView1.Columns[0].Visible = false;
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            //int id = (int)DataBinder.Eval(e.Row.DataItem, "EmployeeID");
            EmployeeDetailsDataPackage emp = (EmployeeDetailsDataPackage)e.Row.DataItem;
            int id = emp.EmployeeID;
            if(id == 48090)
            {                
                e.Row.BackColor = Color.DarkGreen;
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //after the selection is complete
        //get key associated with the selected record
        int id = (int)GridView1.SelectedDataKey["EmployeeID"];

        int myID = Convert.ToInt32(GridView1.SelectedRow.Cells[2].Text);
        Label myLabel = new Label();
        myLabel.Text += id + " " + myID;
        Page.Controls.Add(myLabel);        

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {        
            
    }
}