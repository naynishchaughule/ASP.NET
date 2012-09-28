using System;
using System.Collections.Generic;
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
        Employee emp48090 = new Employee(48090, "naynish", 85000);
        XmlSerializer serial = new XmlSerializer(typeof(Employee));
        Stream stream = File.Create("");
        serial.Serialize(stream, emp48090);
    }
}