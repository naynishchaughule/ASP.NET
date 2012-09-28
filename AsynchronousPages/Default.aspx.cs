using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page
{
    private SqlConnection con;
    private SqlCommand cmd;
    private SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Page.AddOnPreRenderCompleteAsync(new BeginEventHandler(BeginEvent), new EndEventHandler(EndEvent));
        Page.AddOnPreRenderCompleteAsync(BeginTask, EndTask);
    }

    protected IAsyncResult BeginTask(object sender, EventArgs e, AsyncCallback cb, object state)
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        con = new SqlConnection(connectionString);
        cmd = new SqlCommand("SELECT * FROM Products", con);

        try
        {
            con.Open();
        }
        catch (Exception error)
        {
            return new CompletedSyncResult(error, cb, state);
        }
        
        return cmd.BeginExecuteReader(cb, state);
    }

    protected void EndTask(IAsyncResult ar)
    {
        if (ar is CompletedSyncResult)
        {
            lblError.Text = "A connection error occurred.<br />";
            // Demonstrate how exception details can be retrieved.
            lblError.Text += ((CompletedSyncResult)ar).OperationException.Message;
            return;
        }

        try
        {
            //problems with the query processing
            reader = cmd.EndExecuteReader(ar);
        }
        catch (SqlException error)
        {
            Page.Response.Write(error.Message);
        }
    }

    protected void Page_PreRenderComplete(object sender, EventArgs e)
    {
        GridView1.DataSource = reader;
        GridView1.DataBind();
        con.Close();
    }

    public override void Dispose()
    {
        if(con!=null)
        {
            con.Close();
        }
        base.Dispose();
    }
}