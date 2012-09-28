<%@ WebHandler Language="C#" Class="ImageFromDB" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public class ImageFromDB : IHttpHandler {
    
    public void ProcessRequest (HttpContext context)
    {
        //context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        string connectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        string id = context.Request.QueryString["id"];
        if (id == null) throw new ApplicationException("Must specify ID.");
        // Create a parameterized command for this record.
        SqlConnection con = new SqlConnection(connectionString);
        string SQL = "SELECT Photo FROM MyImages WHERE Id=@ID";
        SqlCommand cmd = new SqlCommand(SQL, con);
        cmd.Parameters.AddWithValue("@ID", id);
        try
        {
            con.Open();
            SqlDataReader r =
            cmd.ExecuteReader(CommandBehavior.SequentialAccess);
            if (r.Read())
            {
                int bufferSize = 100; // Size of the buffer.
                byte[] bytes = new byte[bufferSize]; // The buffer of data.
                long bytesRead; // The number of bytes read.
                long readFrom = 0; // The starting index.
                // Read the field 100 bytes at a time.
                do
                {
                    bytesRead = r.GetBytes(0, readFrom, bytes, 0, bufferSize);
                    context.Response.BinaryWrite(bytes);
                    readFrom += bufferSize;
                } while (bytesRead == bufferSize);
            }
            r.Close();
        }
        catch (Exception)
        {
            throw new ApplicationException("Data error");
        }
        finally
        {
            con.Close();
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }
}