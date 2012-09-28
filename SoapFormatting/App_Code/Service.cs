using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

[WebService(Namespace = "https://nash.com/", Description="Obscure SOAP-XML details with WebServicesBinding attribute")]
[SoapDocumentService(RoutingStyle=SoapServiceRoutingStyle.RequestElement)]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[WebServiceBinding(Name = "remote", Namespace = "https://nash.com/", Location = "https://nash.com/MyCustomWebServices")]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]  
    [SoapDocumentMethod(Binding="remote")]
    public double Multiply(double x, double y)        
    {
        return x * y;
    }
}