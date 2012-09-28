using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
public partial class XmlSerial : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Serialize_Click(object sender, EventArgs e)
    {
        PatniEmployee emp48090 = new PatniEmployee(560, 48090, "naynish", 85000);
        XmlSerializer serial = new XmlSerializer(typeof(PatniEmployee));
        Stream stream = File.Create(@"G:\naynish\Pro ASP.NET 4 in C# 2010\Serial\Test.xml");
        serial.Serialize(stream, emp48090);
        stream.Close();
        Label1.Text = " Serialization completed";
    }
    protected void DeSerialize_Click(object sender, EventArgs e)
    {
        XmlSerializer serial = new XmlSerializer(typeof(PatniEmployee));
        Stream stream = File.Open(@"G:\naynish\Pro ASP.NET 4 in C# 2010\Serial\Test.xml", FileMode.Open);
        Employee emp48090 = (PatniEmployee)serial.Deserialize(stream);
        stream.Close();
        Label1.Text = emp48090.ToString();
    }
}