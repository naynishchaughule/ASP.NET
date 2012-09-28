using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RichControls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void AdRotator1_Event(object sender, AdCreatedEventArgs e)
    {
        AdRotator1.NavigateUrlField = "www.google.com";        
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        foreach (DateTime item in Calendar1.SelectedDates)
        {
            Page.Response.Write(item.ToLongDateString() + "<br />");
        }
    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        if (e.Day.IsWeekend)
        {
            e.Cell.BackColor = System.Drawing.Color.Green;
            e.Cell.ForeColor = System.Drawing.Color.Yellow;
            e.Day.IsSelectable = false;
        }
    }
}