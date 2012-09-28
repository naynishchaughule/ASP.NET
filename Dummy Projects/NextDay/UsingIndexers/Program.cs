using System;
using System.Collections.Generic;
using System.Text;

namespace UsingIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeCollection List = new EmployeeCollection();

            List[0] = new Employee(48090, "naynish");
            List[1] = new Employee(48091, "tripti");            
            List[2] = new Employee(48092, "purab");
            
            foreach (Employee item in List)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            int i = 20;
            i.Display();
            MyExtensionClass.Display(30);
            Console.ReadLine();
        }
    }
}
