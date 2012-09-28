using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class EventListener
    {
        public EventListener()
        {
            //method group conversion
            EventScheduler.myEvent += sch_myEvent;
        }

        //delegate covariance
        SeniorEmployee sch_myEvent(object obj, EventArgs e)
        {
            Console.WriteLine(obj.GetType());
            Console.WriteLine(((SchedulerEventArgs)e).Message);
            return new VicePresident(48090, 85000);
        }
    }
}
