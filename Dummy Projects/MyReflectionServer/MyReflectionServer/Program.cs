using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace MyReflectionServer
{
    class Program
    {
        static void Main(string[] args)
        {            
            Assembly asm = Assembly.Load(@"MyReflectionClient, Version=1.0.0.0, PublicKeyToken=null, Culture=""");
            System.Type t = asm.GetType("MyReflectionClient.Employee");
            MethodInfo[] miArray = t.GetMethods();
            Object obj = Activator.CreateInstance(t);
            Console.WriteLine();
            Console.WriteLine("Methods");
            foreach (MethodInfo item in miArray)
            {
                //if(item.Name == "Add")
                //{
                //    item.Invoke(obj, new object[] { 10, 20});
                //}
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Interfaces");
            foreach (var item in t.GetInterfaces())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Fields");
            foreach (var item in t.GetFields())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Types");
            foreach (var item in asm.GetTypes())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
