using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Math <T> where T : IMathCalc
    {
        public void GetSum(T obj)
        {            
            Console.WriteLine(obj.Add(10, 20));
        }
    }
}
