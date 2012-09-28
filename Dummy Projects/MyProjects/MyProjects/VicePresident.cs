using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class VicePresident : SeniorEmployee
    {
        public int ID { get; set; }

        public VicePresident(int id, double sal) : base(sal)
        {
            ID = id;
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, Salary: {1}", ID, base.Salary);
        }    
    }
}
