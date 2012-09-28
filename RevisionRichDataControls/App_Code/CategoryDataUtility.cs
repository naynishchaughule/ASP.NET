using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
/// <summary>
/// Summary description for CategoryDataUtility
/// </summary>
public class CategoryDataUtility
{    
	public CategoryDataUtility()
	{
		
	}
    public DataSet Category_GetAllRecords()
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlCommand cmd = new SqlCommand("select * from category", con);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet dataSet = new DataSet();
        try
        {
            con.Open();
            adapter.Fill(dataSet, "Category");
            return dataSet;
        }
        catch (Exception e)
        {
            throw new ApplicationException(e.Message);
        }
        finally
        {
            con.Close();
        }
    }
    public List<CategoryDataPackage> Category_GetAllRecords(string sortExpression)
    {
        List<CategoryDataPackage> myCategoryList = new List<CategoryDataPackage>();
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlCommand cmd = new SqlCommand("select * from Category", con);
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        DataSet dataSet = new DataSet();
        try
        {
            con.Open();
            adapter.Fill(dataSet, "Category");
            con.Close();
        }
        catch (Exception e)
        {
            throw new ApplicationException(e.Message);
        }
        finally
        {
            con.Close();
        }
        DataView view = dataSet.Tables["Category"].DefaultView;
        view.Sort = sortExpression;
        foreach (DataRowView item in view)
        {
            CategoryDataPackage categoryPackage = new CategoryDataPackage((int)item["CategoryID"], (string)item["CategoryName"]);
            myCategoryList.Add(categoryPackage);
        }
        return myCategoryList;
    }
}