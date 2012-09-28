using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Integer : IMathCalc
    {       
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
