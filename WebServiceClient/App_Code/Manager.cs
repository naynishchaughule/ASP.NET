using System;
using System.Collections.Generic;
using System.Web;
using System.Runtime.Serialization;
using System.Collections;
using System.Xml.Serialization;

/// <summary>
/// Summary description for Manager
/// </summary>

[Serializable]
public class Manager : Employee
{    
    ArrayList contacts = new ArrayList();
    
    [XmlArrayAttribute(ElementName="ContactDetails"), XmlArrayItem(Type=typeof(String), ElementName="Phone")]
    public ArrayList Contacts
    {
        get
        {
            return contacts;
        }
        set
        {
            contacts = value;
        }
    }

    OnsiteClient client;
    public OnsiteClient Client
    {
        get
        {
            return client;
        }
        set 
        {
            client = value;
        }
    }

    string projId;
    public string ProjID
    {
        get
        {
            return projId;
        }
        set
        {
            projId = value;
        }
    }

	public Manager()
	{
		
	}

    public Manager(string projId1, int id, string fname) : base (id, fname)
    {
        ProjID = projId1;
        Client = new OnsiteClient(555, "Christian Dave");
        Contacts.Add("202-714-5352");
        Contacts.Add("992-005-3379");
    }

    public override string ToString()
    {
        return base.ToString() + ", ProjectID: " + ProjID;
    }
}