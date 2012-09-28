using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Security.Tokens;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        SoapContext cntxt = RequestSoapContext.Current;
        if (cntxt == null)
        {
            return "must have soap request context";
        }
        foreach (SecurityToken item in cntxt.Security.Tokens)
        {
            if(item is UsernameToken)
            {
                UsernameToken user = (UsernameToken)item;
                return "user: " + user.Username;
            }
        }
        return "Hello World";
    }
    
}