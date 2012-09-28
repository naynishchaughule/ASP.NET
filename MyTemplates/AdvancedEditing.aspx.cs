using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdvancedEditing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected string[] TitlesOfCourtesy
    {
        get { return new string[] { "Mr.", "Dr.", "Ms.", "Mrs." }; }
    }
    protected int GetSelectedTitle(object title)
    {
        return Array.IndexOf(TitlesOfCourtesy, title.ToString());
    }
}