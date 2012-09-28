using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class Square
    {
        public int side;

        public Square(int s)
        {
            side = s;
        }

        public static explicit operator Square(Rectangle r)
        {
            return new Square(r.length);
        }
    }
}
