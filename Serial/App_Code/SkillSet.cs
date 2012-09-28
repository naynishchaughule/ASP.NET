using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

/// <summary>
/// Summary description for SkillSet
/// </summary>
public class SkillSet
{
    List<string> skSet = new List<string>();
    public List<string> SKSet
    {
        get
        {
            return skSet;
        }
        set
        {
            skSet = value;
        }
    }
	public SkillSet()
	{
		
	}

    public SkillSet(params string[] args)
    {
        foreach (string item in args)
        {
            skSet.Add(item);
        }
    }
}