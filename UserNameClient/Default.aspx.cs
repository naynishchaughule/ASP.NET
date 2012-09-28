using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Web.Services3.Security.Tokens;
using Microsoft.Web.Services3;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MyService.ServiceWse wse = new MyService.ServiceWse();
        wse.SetPolicy("UserTokenClient");
        UsernameToken token = new UsernameToken("naynish", "bhairav@12", PasswordOption.SendPlainText);
        wse.SetClientCredential(token);
        SoapContext reqContext = wse.RequestSoapContext;
        reqContext.Security.Timestamp.TtlInSeconds = 120;
        reqContext.Security.Tokens.Add(token);
        Label1.Text = wse.HelloWorld();
    }
}