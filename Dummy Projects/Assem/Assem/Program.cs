using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace Assem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            MyMath m = new MyMath();
            Console.WriteLine(m.Add(10,20));               
            Console.ReadLine();
        }
    }
}
