using System;
using System.Collections.Generic;
using System.Text;

namespace Lazy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(48090, "naynish");
            emp.GetFname(48090);
            emp.GetStringArrayPersonalDetails();
        }
    }
}
