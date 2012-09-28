using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

public class Nash
{
    [XmlAttribute(AttributeName="HundredK")]
    public double Salary;    
}

[WebService(Namespace = "http://nash.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    Nash myName = new Nash();
    [WebMethod(), SoapDocumentMethod(RequestElementName="requestSalary", ResponseElementName="serviceSalary")]
    public double DisplaySalary([XmlElement("start")] Nash begin)
    {
        begin.Salary = 200000;
        return begin.Salary;            
    }

    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public DataSet GetProducts()
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlCommand cmd = new SqlCommand("select * from Products" , con);
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        DataSet dataSet = new DataSet();
        try
        {
            con.Open();
            adapter.Fill(dataSet, "Products");
            con.Close();
            return dataSet;
        }
        catch (Exception)
        {
            throw new ApplicationException();
        }
        finally
        {
            con.Close();
        }
    }
}