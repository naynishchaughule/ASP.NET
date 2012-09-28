using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Math<Integer> Obj = new Math<Integer>();
            Obj.GetSum(new Integer());
            Console.ReadLine();
        }
    }
}
