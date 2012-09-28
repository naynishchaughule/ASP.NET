using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingBasics
{
    class Timer
    {
        static void Main(string[] args)
        {
            TimerCallback callBack = new TimerCallback(PrintTime);

            System.Threading.Timer t = new System.Threading.Timer(callBack, null, 0, 1000);
            Console.ReadLine();
        }

        static void PrintTime(Object obj)
        {
            Console.WriteLine(System.DateTime.Now.Second);
        }
    }
}
