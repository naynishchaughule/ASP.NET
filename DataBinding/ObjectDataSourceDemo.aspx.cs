using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ObjectDataSourceDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ObjectDataSource1_ObjectCreating(object sender, ObjectDataSourceEventArgs e)
    {
        //e.ObjectInstance = new EmployeeDetailsDataUtility();
    }
}