using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Manager : Employee, Interface1
    {
        public string name;

        public Manager(int id, string name) : base(id)
        {
            this.name = name;                   
        }
    }
}
