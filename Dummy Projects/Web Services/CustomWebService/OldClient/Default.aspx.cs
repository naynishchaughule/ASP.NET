using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OldClient
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NashService.Service1 svc = new NashService.Service1();
            Page.Response.Write(svc.HelloWorld());
            RestNash.Currency c = new RestNash.Currency();
            c.FromCurrency = RestNash.CurrencyCode.INR;
            c.ToCurrency = RestNash.CurrencyCode.USD;
            c.Rate = 54;
            double dollars = 1000 * c.Rate;
            Page.Response.Write(dollars);
        }
    }
}