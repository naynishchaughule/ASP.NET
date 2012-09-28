using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticDemo
{
    class Program
    {
        static int ij = 90;
        static void Main(string[] args)
        {
            //const int data = 90;
            //Employee emp1 = new Employee(48090);
            //Employee emp2 = new Employee(65985);            
            
            //Console.WriteLine(data);

            for (int i = 0; i < 5; i++)
            {
                ij = 0;
                for (int j = 0; j < 5; j++)
                {                    
                    ij++;
                }
            }
            Console.WriteLine("ij {0}", ij);
            Employee obj;
            for (int i = 0; i < 2; i++)
            {
                Employee.deptCount = 0;             
                for (int j = 0; j < 2; j++)
                {                    
                    obj = new Employee(Employee.employeeCount);
                    obj.deptId = i + 787;
                    Display(obj);
                }
            }
            Console.WriteLine(Employee.deptCount);
            //Display(emp1); Display(emp2);
            Console.ReadLine();
        }

        public static void Display(Employee emp)
        {
            //Console.WriteLine("Employee count: {0}", Employee.employeeCount);
            Console.WriteLine(emp);
        }
    }
}
