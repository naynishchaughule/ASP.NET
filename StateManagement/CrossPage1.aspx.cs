using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CrossPage1 : System.Web.UI.Page
{
    public string TextName
    {
        get
        {
            return txtName.Text;
        }
    }

    public string TextAge
    {
        get
        {
            return txtAge.Text;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
}