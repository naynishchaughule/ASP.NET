using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for EmployeeDetailsDataUtility
/// </summary>
public class EmployeeDetailsDataUtility
{
    private string connectionString;
	public EmployeeDetailsDataUtility()
	{
        connectionString = WebConfigurationManager.ConnectionStrings["Nash"].ConnectionString;
	}
    public EmployeeDetailsDataUtility(string connectionString)
    {
        this.connectionString = connectionString;
    }
    public int InsertEmployee(EmployeeDetailsDataPackage emp)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.CommandText = "InsertEmployee";
        cmd.Parameters.Add("@EmployeeID", emp.EmployeeID);
        
        cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 256));
        cmd.Parameters["@FirstName"].Value = emp.FirstName;

        cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 256));
        cmd.Parameters["@LastName"].Value = emp.LastName;

        cmd.Parameters.Add(new SqlParameter("@TitleOfCourtesy", SqlDbType.NVarChar, 256));
        cmd.Parameters["@TitleOfCourtesy"].Value = emp.TitleOfCourtesy;

        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            return (int)cmd.Parameters["@EmployeeID"].Value;
        }
        catch (SqlException error)
        {
            throw new ApplicationException("Data error");
        }
        finally
        {
            con.Close();
        }
    }
    public void DeleteEmployee(int employeeID)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@EmployeeID", SqlDbType.Int);
        cmd.Parameters["@EmployeeID"].Value = employeeID;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (SqlException error)
        {
            throw new ApplicationException("Data error");
        }
        finally
        {
            con.Close();
        }
    }
    public void UpdateEmployee(int EmployeeID, string firstName, string lastName, string titleOfCourtesy)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "UpdateEmployee";
        cmd.Connection = con;
        cmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 4);
        cmd.Parameters["@EmployeeID"].Value = EmployeeID;

        cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 256);
        cmd.Parameters["@FirstName"].Value = firstName;

        cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 256);
        cmd.Parameters["@LastName"].Value = lastName;

        cmd.Parameters.Add("@TitleOfCourtesy", SqlDbType.NVarChar, 256);
        cmd.Parameters["@TitleOfCourtesy"].Value = titleOfCourtesy;

        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (SqlException error)
        {
            throw new ApplicationException("Data error");
        }
        finally
        {
            con.Close();
        }
    }
    public EmployeeDetailsDataPackage GetEmployee(int employeeID)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("GetEmployee", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
        cmd.Parameters["@EmployeeID"].Value = employeeID;
        try
        {
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (!reader.Read())
                return null;
            //reader.Read();
            EmployeeDetailsDataPackage emp = new EmployeeDetailsDataPackage((int)reader.GetValue(0), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
            reader.Close();
            return emp;
        }
        catch (SqlException error)
        {
            throw new ApplicationException("Data error");
        }
        finally
        {
            con.Close();
        }
    }
    public List<EmployeeDetailsDataPackage> GetEmployees()
    {        
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("GetAllEmployees", con);
        cmd.CommandType = CommandType.StoredProcedure;
        List<EmployeeDetailsDataPackage> list = new List<EmployeeDetailsDataPackage>();
        try
        {
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EmployeeDetailsDataPackage emp = new EmployeeDetailsDataPackage((int)reader.GetValue(0), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
                list.Add(emp);
            }
            reader.Close();
            return list;
        }
        catch (SqlException error)
        {
            throw new ApplicationException("Data error");
        }
        finally
        {
            con.Close();
        }
    }
    public int CountEmployees()
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("CountEmployees", con);
        cmd.CommandType = CommandType.StoredProcedure;        
        try
        {
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        catch (SqlException error)
        {
            throw new ApplicationException("Data error");
        }
        finally
        {
            con.Close();
        }
    }
}