using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingBasics
{
    class ThreadingDemo
    {
        public static AutoResetEvent waitHandle = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Employee emp = new Employee(48090, "naynish", 85000);
            Thread current = Thread.CurrentThread;
            current.Name = "Primary thread";
            current.Priority = ThreadPriority.Normal;
            current.IsBackground = false;

            Thread th = new Thread(new ParameterizedThreadStart(emp.Display));
            th.Name = "Secondary thread";
            th.Priority = ThreadPriority.Normal;
            th.IsBackground = true;
            th.Start(emp);
            waitHandle.WaitOne();
            Console.WriteLine("End of program");
            Console.ReadLine();
        }
    }
}
