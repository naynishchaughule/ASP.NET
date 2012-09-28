using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

/// <summary>
/// Summary description for BloggingCommentsDataUtility
/// </summary>
public class BloggingCommentsDataUtility
{
	public BloggingCommentsDataUtility()
	{
		
	}

    public DataSet GetAllComments()
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Nash"].ConnectionString);
        SqlCommand cmd = new SqlCommand("select * from BloggingComments", con);
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        DataSet dataSet = new DataSet();
        try
        {
            con.Open();          
            adapter.Fill(dataSet, "BloggingComments");
            con.Close();
        }
        catch (Exception e)
        {
            throw new ApplicationException(e.Message);
        }

        return dataSet;
    }
}