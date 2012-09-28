using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeDetailsDataUtility objUtility = new EmployeeDetailsDataUtility();
        //objUtility.InsertEmployee(new EmployeeDetailsDataPackage(48090, "naynish", "chaughule", "developer"));
        //objUtility.InsertEmployee(new EmployeeDetailsDataPackage(65985, "tripti", "panjabi", "retail"));
        //Page.Response.Write(objUtility.CountEmployees());
        //GridView1.DataSource = objUtility.GetEmployees();
        //GridView1.DataBind();
        //Page.Response.Write((objUtility.GetEmployee(48090)).FirstName);
        //objUtility.UpdateEmployee(48090, "nash", "c", "programmer");
        objUtility.DeleteEmployee(48090);
    }
}