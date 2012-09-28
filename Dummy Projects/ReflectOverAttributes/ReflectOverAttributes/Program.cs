using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectOverAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load("MyAttribute");
            Type t1 = asm.GetType("MyAttribute.Program");

            Type t2 = asm.GetType("MyAttribute.EmployeeDescriptionAttribute");
            PropertyInfo pi = t2.GetProperty("Message");
            
            foreach (var item in t1.GetCustomAttributes(t2,false))
            {
                Console.WriteLine(pi.GetValue(item,null));
            }
            Console.ReadLine();
        }
    }
}
