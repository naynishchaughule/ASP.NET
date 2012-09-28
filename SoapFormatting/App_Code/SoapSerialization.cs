using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

public class Diving
{
    [XmlAttribute()]
    public int x;
    [XmlAttribute()]
    public int y;
}

/// <summary>
/// Summary description for SoapSerialization
/// </summary>
[WebService(Namespace = "http://nash.org/", Description="Soap Formatting Demo")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class SoapSerialization : System.Web.Services.WebService {

    public SoapSerialization () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [SoapDocumentMethod(Action = "http://nash.org/Action", RequestNamespace = "http://nash.org/Request", RequestElementName = "Req", ResponseNamespace = "http://nash.org/Response", ResponseElementName = "Res")]
    [WebMethod]
    public Diving Display([XmlAttribute(AttributeName = "x")] int x, [XmlAttribute(AttributeName = "y")] int y)
    {
        Diving div = new Diving();
        div.x = x;
        div.y = y;
        return div;
    }    
}
