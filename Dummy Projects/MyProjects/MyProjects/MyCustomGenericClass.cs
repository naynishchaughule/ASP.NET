using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class MyCustomGenericClass<T> where T :  Interface1, new ()
    {
        public void Add(T point)
        {
            point.Add();
        }
    }
}





