using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectionBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = System.Type.GetType("ReflectionBasics.Employee");
            Console.WriteLine(t);
            Assembly asm = Assembly.Load("ClientForReflection");
            
            Type t1 = asm.GetType("ClientForReflection.Program");            
            object obj = Activator.CreateInstance(t1);

            MethodInfo mi = t1.GetMethod("Display");
            mi.Invoke(obj, null);
            Console.ReadLine();
        }
    }
}
