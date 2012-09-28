using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Web.UI;

/// <summary>
/// Summary description for EmployeeDetailsDataUtility
/// </summary>
public class EmployeeDetailsDataUtility
{
    private string connectionString;
	public EmployeeDetailsDataUtility()
	{
        connectionString = WebConfigurationManager.ConnectionStrings["nash"].ConnectionString;
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

    public DataSet GetAllMyEmployees()
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Nash"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Employees";
        cmd.Connection = con;
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        DataSet dataSet = new DataSet();
        try
        {
            con.Open();
            adapter.Fill(dataSet, "Employees");
            con.Close();
        }
        catch (Exception)
        {
            throw new ApplicationException("Data error");
        }
        return dataSet;
    }

    public List<EmployeeDetailsDataPackage> GetObjectEmployees(string sortExpression)
    {
        List<EmployeeDetailsDataPackage> myList = new List<EmployeeDetailsDataPackage>();
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Nash"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Employees";
        cmd.Connection = con;
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        DataSet dataSet = new DataSet();
        try
        {
            con.Open();
            adapter.Fill(dataSet, "Employees");
            con.Close();
        }
        catch (Exception)
        {
            throw new ApplicationException("Data error");
        }

        DataView view = dataSet.Tables["Employees"].DefaultView;
        view.Sort = sortExpression;
        foreach (DataRowView item in view)
        {
            EmployeeDetailsDataPackage emp = new EmployeeDetailsDataPackage((int)item[0], item[1].ToString(), item[2].ToString(), item[3].ToString());
            myList.Add(emp);
        }
        return myList;
    }

    public EmployeeDetailsDataPackage[] GetEmployees(int startRowIndex, int maximumRows)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("GetEmployeePage", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@Start", SqlDbType.Int, 4));
        cmd.Parameters["@Start"].Value = startRowIndex + 1;
        cmd.Parameters.Add(new SqlParameter("@Count", SqlDbType.Int, 4));
        cmd.Parameters["@Count"].Value = 5;
        // Create a collection for all the employee records.
        ArrayList employees = new ArrayList();
        try
        {
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EmployeeDetailsDataPackage emp = new EmployeeDetailsDataPackage(
            (int)reader["EmployeeID"], (string)reader["FirstName"],
            (string)reader["LastName"], (string)reader["TitleOfCourtesy"]);
            employees.Add(emp);
            }
            reader.Close();
            return (EmployeeDetailsDataPackage[])employees.ToArray(typeof(EmployeeDetailsDataPackage));
        }
        catch (SqlException err)
        {
            throw new ApplicationException("Data error.");
        }
        finally
        {
            con.Close();
        }
    }

    public static string TravelRequest(object dataItem)
    {
        int ID = (int)DataBinder.Eval(dataItem, "EmployeeID");
        if (ID == 48090)
        {
            return "Travel Request Rejected";
        }
        else
            return "Travel Request Approved";
    }

    public void UpdateEmployee(int employeeID, string titleOfCourtesy)
    {
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "update Employees set TitleOfCourtesy=@TitleOfCourtesy where EmployeeID=@EmployeeID";
        cmd.Parameters.Add(new SqlParameter("@TitleOfCourtesy", titleOfCourtesy));
        cmd.Parameters.Add(new SqlParameter("@EmployeeID", employeeID));
        cmd.Connection = con;
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
}