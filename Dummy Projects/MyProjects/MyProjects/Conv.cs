using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class Conv
    {
        static void Main(string[] args)
        {
            Square s = new Square(20);
            Rectangle rect = (Rectangle)s;
            Console.WriteLine("Rectangle Length: {0}, Height: {1}", rect.length, rect.height);
            Console.ReadLine();
        }
    }
}
