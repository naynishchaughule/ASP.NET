using System;
using System.Collections.Generic;
using System.Web;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

[Serializable]
public class Employee
{
    int _ID;
    string _Fname;
    double _Salary;

    [XmlAttributeAttribute(AttributeName="Key")]
    public int ID 
    {
        get
        {
            return _ID;
        }
        set
        {
            _ID = value;
        }
    }

    public string Fname
    {
        get
        {
            return _Fname;
        }
        set
        {
            _Fname = value;
        }
    }

    public double Salary
    {
        get
        {
            return _Salary;
        }
        set
        {
            _Salary = value;
        }
    }

	public Employee()
	{    

	}

    public Employee(int id, string fname, double salary)
    {
        ID = id; Fname = fname; Salary = salary;
    }

    public override string ToString()
    {
        return String.Format("ID: {0}, Fname: {1}, Salary: {2}", ID, Fname, Salary);
    }    
}