using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            hello obj = new hello();
            Console.WriteLine(obj.i);
            Console.ReadLine();
        }
    }

    class hello
    {
        public int i = 10;
    }
}
