using System;
using System.Collections.Generic;
using System.Text;

namespace UsingIndexers
{
    class Employee
    {
        int id;
        string name;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name        
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Employee(int id, string name)
        {
            Id = id; Name = name;
        }
    }
}
