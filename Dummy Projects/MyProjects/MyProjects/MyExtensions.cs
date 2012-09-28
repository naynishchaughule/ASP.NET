using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    static class MyExtensions
    {
        public static void Display(this int x, int y)
        {
            Console.WriteLine("X: {0}, Y: {1}", x, y);
        }
    }
}
