using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Serialization;

namespace ThreadingBasics
{
    class TPL
    {
        static AutoResetEvent eve = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            //starts on a new thread
            //Task.Factory.StartNew(Pa);
            Parallel.Invoke(Pa);
            eve.WaitOne();
            Console.WriteLine("End");
            Console.ReadLine();
        }

        public static void Pa()
        {
            Thread.Sleep(3000);
            List<string> names = new List<string>();
            names.Add("naynish"); names.Add("jay");
            names.Add("tripti"); names.Add("purab");
            Parallel.ForEach(names, Display);
            var result = from item in names.AsParallel()
                         select item;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            eve.Set();
        }

        public static void Display(string s)
        {
            Console.WriteLine(s + " hello");
        }
    }
}
