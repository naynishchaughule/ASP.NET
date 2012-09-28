using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WikiCommentsDataPackage
/// </summary>
public class WikiCommentsDataPackage
{
    public int UserID { get; set; }
    public string UserComments { get; set; }

	public WikiCommentsDataPackage()
	{
		
	}

    public WikiCommentsDataPackage(int userID, string userComments)
    {
        UserID = userID; UserComments = userComments;
    }
}