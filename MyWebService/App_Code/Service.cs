using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

[WebService(Namespace = "http://nash.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Service : System.Web.Services.WebService
{
    string con = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public DataSet GetProducts(int productID)
    {
        SqlConnection myConnection = new SqlConnection(con);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Products where ProductID=@ProductID";
        cmd.Connection = myConnection;
        SqlParameter paramProductID = new SqlParameter("@ProductID", productID);
        cmd.Parameters.Add(paramProductID);
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        try
        {
            myConnection.Open();
            adapter.Fill(dataSet);
            return dataSet;
        }
        catch (Exception)
        {
            throw new ApplicationException("error GetProducts");
        }
    }
}
