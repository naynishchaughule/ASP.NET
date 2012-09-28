using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class Point : Interface1
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {

        }

        public Point(int x, int y)
        {
            X = x; Y = y;                        
        }

        public void Add()
        {
            Console.WriteLine("Sum: {0}", X + Y);
        }
    }
}
