using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

/// <summary>
/// Summary description for WikiCommentsDataUtility
/// </summary>
public class WikiCommentsDataUtility
{
	public WikiCommentsDataUtility()
	{
		
	}

    public DataSet GetAllComments()
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["nash"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType= CommandType.Text;
        cmd.CommandText = "select * from WikiComments";
        cmd.Connection = con;
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        DataSet dataSet = new DataSet();
        try 
	    {	        
		    adapter.Fill(dataSet, "WikiComments");
            return dataSet;
	    }
	    catch (Exception e)
	    {
		    throw new ApplicationException(e.Message);
	    }
    }

    public void Update(int userID, String userComments)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["nash"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "update WikiComments set UserComments=@UserComments where UserID=@UserID";
        cmd.Connection = con;
        cmd.Parameters.Add(new SqlParameter("@UserID", userID));        
        cmd.Parameters.Add(new SqlParameter("@UserComments", userComments));        
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();            
        }
        catch (Exception e)
        {
            throw new ApplicationException(e.Message);
        }
    }
}