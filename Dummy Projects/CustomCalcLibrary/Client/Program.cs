using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomCalcLibrary;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            Console.WriteLine(m.Add(10, 20));
            Console.ReadLine();
        }
    }
}
