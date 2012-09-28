using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAdd
{
    class Math<T> where T : ISalaryCalc
    {
        public void GetSum(T x, T y)
        {
            
        }
    }
}
