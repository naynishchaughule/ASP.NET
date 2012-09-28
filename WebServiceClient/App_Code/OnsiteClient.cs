using System;
using System.Collections.Generic;
using System.Web;
using System.Xml.Serialization;

public class OnsiteClient
{
    int clientID;
    [XmlAttribute("ClientID")]
    public int ClientID
    {
        get
        {
            return clientID;
        }
        set
        {
            clientID = value;
        }
    }

    string clientName;
    public string ClientName
    {
        get
        {
            return clientName;
        }
        set
        {
            clientName = value;
        }
    }

	public OnsiteClient()
	{
		
	}

    public OnsiteClient(int id, string name)
    {
        ClientID = id;
        ClientName = name;
    }
}