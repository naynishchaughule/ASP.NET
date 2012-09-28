using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class Manager
    {
        public int MgrID { get; set; }
        public string Name { get; set; }
        public string Project { get; set; }

        public Manager(int id, string name, string projName)
        {
            MgrID = id; Name = name; Project = projName;
        }
    }
}
