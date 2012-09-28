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
        //Tools --> Options --> Text Editor --> C# --> Formatting section
        //cntrl + ,
        //Website --> Start Options
        //Tools --> Options --> HTML Designer --> General --> Split views vertically
        //Tools --> Options --> Environment --> Task List
        
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        //moniker
        //todo: refine code
        Text1.Value = Calendar1.SelectedDate.ToLongDateString();
    }
}