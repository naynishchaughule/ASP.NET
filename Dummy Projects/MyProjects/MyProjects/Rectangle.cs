using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class Rectangle
    {
        public int length { get; set; }
        public int height { get; set; }

        public Rectangle(int ln, int h)
        {
            length = ln; height = h;
        }

        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.side, s.side + 10);
        }
    }
}
