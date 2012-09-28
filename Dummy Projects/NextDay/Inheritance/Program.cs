using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {            
            Manager m = new Manager(48090, "naynish");            
            Display(m);
            Console.ReadLine();
        }

        static void Display(Interface1 e)
        {
            if(e is Manager)
                Console.WriteLine(((Manager)e).name);
        }
    }
}
