using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Employee.OrgId);
            Employee.OrgId = 90;
            Employee emp1 = new Employee(48090);
            Console.WriteLine(emp1.Id + " " + Employee.OrgId);
            Employee emp2 = new Employee(65985);
            Console.WriteLine(emp1.Id + " " + Employee.OrgId);
            //Console.WriteLine(Employee.count);
            Employee.Display();
            Console.ReadLine();
        }
    }
}
