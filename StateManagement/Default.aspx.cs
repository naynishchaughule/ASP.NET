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
        if (!Page.IsPostBack)
        {
            Employee Emp48090 = new Employee(48090, "naynish", 85000);
            ViewState["Emp48090"] = Emp48090; 
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (ViewState["Emp48090"] != null)
        {
            Label1.Text = ViewState["Emp48090"].ToString();
        }
    }
}