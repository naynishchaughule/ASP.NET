using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MyPoint(int x, int y)
        {
            X = x; Y = y;
        }

        public static MyPoint operator + (MyPoint p1, MyPoint p2)
        {
            return new MyPoint(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static MyPoint operator ++(MyPoint p1)
        {
            return new MyPoint(p1.X + 1, p1.Y + 1);
        }

        public static bool operator == (MyPoint p1, MyPoint p2)
        {
            return (p1.ToString().GetHashCode() == p2.ToString().GetHashCode())? true : false;
        }

        public static bool operator != (MyPoint p1, MyPoint p2)
        {
            return (p1.ToString().GetHashCode() != p2.ToString().GetHashCode()) ? true : false;
        }      

        public override string ToString()
        {
            return String.Format("MyPoint X: {0}, Y: {1}", X, Y);
        }
    }
}
