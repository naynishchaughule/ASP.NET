using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BloggingCommentsDataPackage
/// </summary>
public class BloggingCommentsDataPackage
{
    public string Comments { get; set; }
	public BloggingCommentsDataPackage()
	{
		
	}
    public BloggingCommentsDataPackage(string comments)
    {
        Comments = comments;
    }
}