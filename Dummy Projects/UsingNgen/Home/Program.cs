using System;
using System.Collections.Generic;
using System.Text;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {            
            Car c = new Car();
            foreach (string item in c)
            {
                //Console.WriteLine(item);
            }
            
            int[] arr = new int[] { 10, 2, 5};
            Array.Sort(arr, c);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
