using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
/// <summary>
/// Summary description for ProductsDataUtility
/// </summary>
public class ProductsDataUtility
{
	public ProductsDataUtility()
	{

	}
    public List<ProductsDataPackage> Products_GetAllRecords()
    {
        List<ProductsDataPackage> myListProducts = new List<ProductsDataPackage>();
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Products";
        cmd.Connection = con;                
        try
        {
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ProductsDataPackage products = new ProductsDataPackage((int)reader.GetValue(0), (int)reader.GetValue(1), (string)reader.GetValue(2), (decimal)reader.GetValue(3), (int)reader.GetValue(4));
                myListProducts.Add(products);
            }
            con.Close();
            return myListProducts;
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
    public void Products_UpdateProductName(string productName, int productID)
    {        
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "update Products set ProductName=@ProductName where ProductID=@ProductID";
        cmd.Connection = con;
        cmd.Parameters.Add("@ProductName", SqlDbType.VarChar);
        cmd.Parameters["@ProductName"].Value = productName;
        cmd.Parameters.Add(new SqlParameter("@ProductID",productID));
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
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
    }
}