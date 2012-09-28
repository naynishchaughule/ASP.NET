using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.ServiceReference1;

namespace Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service1SoapClient sc = new Service1SoapClient();
            Page.Response.Write(sc.HelloWorld());
        }
    }
}