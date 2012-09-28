using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class Employee : ICloneable
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public Manager manager;

        public Employee(int id, string name, Manager mgr)
        {
            EmpID = id; Name = name; manager = mgr;
        }

        public object Clone()
        {
            return new Employee(EmpID, Name, new Manager(this.manager.MgrID, this.manager.Name, this.manager.Project));
        }
    }
}
