using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
[Serializable]
public class Employee
{
    public int Id { get; set; }
    public string Fname { get; set; }
    public double Salary { get; set; }

    public Employee()
    {

    }

    public Employee(int id, string name, double salary)
    {
        Id = id; Fname = name; Salary = salary;
    }

    public override string ToString()
    {
        return String.Format("Employee Id: {0}, Fname: {1}, Salary: {2}", Id, Fname, Salary);
    }
}