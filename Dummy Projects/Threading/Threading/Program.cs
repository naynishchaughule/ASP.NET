using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace Threading
{
    public delegate int Add(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Add obj = new Add(Sum);
            IAsyncResult result = obj.BeginInvoke(10, 20, new AsyncCallback(MyDisplay), null);            
            Console.ReadLine();
        }

        static int Sum(int x, int y)
        {
            Console.WriteLine();            
            Thread.Sleep(5000);
            return x + y;
        }

        static void MyDisplay(IAsyncResult res)
        {
            AsyncResult asyn = (AsyncResult)res;
            Add obj = (Add)asyn.AsyncDelegate;
            Console.WriteLine(obj.EndInvoke(res));
        }
    }
}
