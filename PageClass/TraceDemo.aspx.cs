using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TraceDemo : System.Web.UI.Page
{
    string employeeFname = "naynish p. chaughule";
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Response.Write(Page.Session.SessionID);
        //System.Web.TraceContext
        //Page.Trace.IsEnabled = true;
        //Trace.TraceMode = TraceMode.SortByCategory;
        Page.Session.Add("nash", "chaughule");
        Page.Application.Add("App", "objState");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.Response.Write("Button1_Click");
        //http://localhost:1895/PageClass/Trace.axd
        Trace.Warn("Author", "<b>Warning</b>");

        Trace.TraceFinished += new TraceContextEventHandler(Trace_TraceFinished);

        //System.Web.HttpContext
        HttpContext htc = HttpContext.Current;
        htc.Response.Write("using HttpContext");
        Class1 c = new Class1();
        c.MyHttpContext(HttpContext.Current);
    }

    void Trace_TraceFinished(object sender, TraceContextEventArgs e)
    {
        foreach (TraceContextRecord item in e.TraceRecords)
	    {
            Page.Response.Write(item.Message + "<br />");
	    }        
    }
}