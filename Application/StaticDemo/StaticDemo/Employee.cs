using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticDemo
{
    class Employee
    {
        public static int employeeCount = 0;
        public int deptId;
        public static int deptCount = 0;
        public int Id { get; set; }
        public Employee (int id)
	    {
            Id = id;
            deptId = 787;
            employeeCount++;
            deptCount++;
	    }

        public override string ToString()
        {
            return string.Format("Employee Id: {0}, DeptId: {1}", Id, deptId);
        }
    }
}
