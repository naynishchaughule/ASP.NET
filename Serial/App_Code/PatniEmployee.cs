using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class PatniEmployee : Employee
{
    public int OrgCode { get; set; }
    public SkillSet Skills { get; set; }

	public PatniEmployee()
	{	

	}

    public PatniEmployee(int orgCode, int id, string fname, double salary) : base (id, fname, salary)
    {
        OrgCode = orgCode;
        Skills = new SkillSet("vb", "c#", "asp.net");        
    }

    public override string ToString()
    {
        return base.ToString() + ", Org Code: " + OrgCode;
    }
}