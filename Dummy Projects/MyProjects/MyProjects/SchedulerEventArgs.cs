using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class SchedulerEventArgs : EventArgs
    {
        public string Message { get; set; }

        public SchedulerEventArgs(string msg)
        {
            Message = msg;
        }
    }
}
