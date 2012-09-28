using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using InterfaceImplementation;

namespace Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom(@"C:\Users\naynish\Desktop\Dummy Projects\Advanced\Extension\Extension\bin\Debug\Extension.dll");
            var result = from item in asm.GetTypes()
                         where item.GetInterface("IDisplay") != null
                         select item;
            foreach (var item in result)
            {
                IDisplay dp = (IDisplay)Activator.CreateInstance(item);
                dp.Show();
            }                        
            Console.ReadLine();
        }
    }
}
