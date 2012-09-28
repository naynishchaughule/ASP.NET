using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LinqGroupBy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Employee> myEmployeeList = new List<Employee>();
        myEmployeeList.Add(new Employee(48090, "naynish", 85000));
        myEmployeeList.Add(new Employee(65985, "purab", 65000));
        myEmployeeList.Add(new Employee(48090, "tripti", 75000));
        myEmployeeList.Add(new Employee(48090, "jay", 55000));
        myEmployeeList.Add(new Employee(65985, "praloy", 55000));
        myEmployeeList.Add(new Employee(65985, "malvika", 95000));

        var result = from item in myEmployeeList
                     group item by item.Id into g
                     select new { ID = g.Key, Sum = g.Sum(
                                                             delegate (Employee item) { return item.Salary;}
                                                         )                  
                                };
                                                       
        GridView1.DataSource = result;
        GridView1.DataBind();
    }
}