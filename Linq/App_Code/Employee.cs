using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
public class Employee
{
    public int Id { get; set; }
    public string Fname { get; set; }
    public double Salary { get; set; }

	public Employee(int id, string fname, double salary)
	{
        Id = id; Fname = fname; Salary = salary;
	}

    public override string ToString()
    {
        return String.Format("Id: {0}, Fname: {1}, Salary: {2}", Id, Fname, Salary);
    }
}