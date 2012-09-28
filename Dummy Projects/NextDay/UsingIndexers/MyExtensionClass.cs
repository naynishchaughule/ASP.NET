using System;
using System.Collections.Generic;
using System.Text;

namespace UsingIndexers
{
    static class MyExtensionClass
    {
        public static void Display(this int i)
        {
            Console.WriteLine(i);
        }
    }
}
