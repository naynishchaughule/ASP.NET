using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    public delegate SeniorEmployee MyDelegate(Object obj, EventArgs e);
    public delegate void GenDelegate<T>(T x);

    class EventScheduler
    {
        public static event MyDelegate myEvent;
        public static event GenDelegate<int> genEvent;
        public void RaiseEvent()
        {
            if(myEvent.GetInvocationList() != null)
                Console.WriteLine(myEvent.Invoke(this, new SchedulerEventArgs("hello world")));
            genEvent += new GenDelegate<int>(EventScheduler_genEvent);
            genEvent.Invoke(20);
        }

        void EventScheduler_genEvent(int x)
        {
            Console.WriteLine("Call from generic delegate " + x);                
        }
    }
}
