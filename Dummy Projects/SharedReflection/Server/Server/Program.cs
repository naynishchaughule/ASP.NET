using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load(@"ClientLib, Version=1.0.0.0, PublicKeyToken=0fc8791152c8facd, Culture=""");
            Type t = asm.GetType("ClientLib.Employee");            
            foreach (var item in t.GetMembers())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
