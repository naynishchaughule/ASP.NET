using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Limits : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {            
            DropDownList1.DataSourceID = "ObjectDataSource1";
            DropDownList1.DataTextField = "EmployeeID";
            DropDownList1.DataValueField = "EmployeeID";
            DropDownList1.AutoPostBack = true;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Select an ID");
            DropDownList1.Items.Insert(1, "All Employees");
            DropDownList1.SelectedIndex = 2;            
        }
        if (DropDownList1.SelectedValue == "Select an ID" || DropDownList1.SelectedValue == "All Employees")
            DropDownList1.SelectedIndex = 2;
    }   
}