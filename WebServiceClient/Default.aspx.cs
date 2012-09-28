using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BasicService;
using System.Xml.Serialization;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BasicService.Service svc = new Service();
        IAsyncResult result = svc.BeginGetProducts(null, null);

        result.AsyncWaitHandle.WaitOne();
        GridView1.DataSource = svc.EndGetProducts(result);
        GridView1.DataBind();
    }
    protected void Serialize_Click(object sender, EventArgs e)
    {
       Manager mgr = new Manager("MOL 89220", 65985, "naynish");
       XmlSerializer XSerializer = new XmlSerializer(typeof(Manager));
       //Stream stream = File.Create(@"G:\naynish\Pro ASP.NET 4 in C# 2010\WebServiceClient\Test.xml");        
       Stream stream = File.Create(Server.MapPath("Test.xml"));        
       XSerializer.Serialize(stream, mgr);
       stream.Close();
       Label1.Text = "Serialization Complete";
    }
    protected void DeSerialize_Click(object sender, EventArgs e)
    {
        XmlSerializer XSerializer = new XmlSerializer(typeof(Manager));
        Stream stream = File.Open(Server.MapPath("Test.xml"), FileMode.Open);
        Manager mgr = (Manager)XSerializer.Deserialize(stream);
        stream.Close();
        Label1.Text = mgr.ToString();
    }
}