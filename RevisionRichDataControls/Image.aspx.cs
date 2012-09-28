using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Image : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select Photo from MyImages where Id=10";
        cmd.Connection = con;
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
                    Response.BinaryWrite(bytes);
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
}