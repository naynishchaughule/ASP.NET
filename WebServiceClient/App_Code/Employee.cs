using System;
using System.Collections.Generic;
using System.Web;
using System.Xml.Serialization;

/// <summary>
/// Summary description for Employee
/// </summary>

[Serializable]
public class Employee
{
    [XmlAttribute("OrganizationCode")]
    public int OrgCode = 4128;

    int id;
    public int ID
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    string fname;
    public string Fname
    {
        get
        {
            return fname;
        }
        set
        {
            fname = value;
        }
    }

	public Employee()
	{
		
	}

    public Employee(int id1, string fname1)
    {
        ID = id1; Fname = fname1;
    }

    public override string ToString()
    {
        return String.Format("ID: {0}, Fname: {1}", ID, Fname);
    }
}