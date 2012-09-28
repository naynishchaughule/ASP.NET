using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

/// <summary>
/// Summary description for CustomerDataUtility
/// </summary>
public class CustomerDataUtility
{
	public CustomerDataUtility()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public List<CustomerDataPackage> GetAllCustomers()
    {
        List<CustomerDataPackage> myList = new List<CustomerDataPackage>();
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Nash"].ConnectionString);
        SqlCommand cmd = new SqlCommand("select * from Customer", con);
        try
        {
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CustomerDataPackage custPackage = new CustomerDataPackage((int)reader.GetValue(0), (string)reader.GetValue(1));
                myList.Add(custPackage);             
            }
            reader.Close();
            return myList;            
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

    public static string GetStatusPicture(object dataItem)
    {
        int count = Int32.Parse(DataBinder.Eval(dataItem, "ID").ToString());
        if (count == 48090)
        {
            return "image.jpg";
        }
        else
            return "Hello";
    }
}