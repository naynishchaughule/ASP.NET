using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class Course : IComparable
    {
        public int Csci { get; set; }
        public string Name { get; set; }
        public int StudentCount { get; set; }

        public Course(int id, string name, int count)
        {
            Csci = id; Name = name; StudentCount = count;
        }

        public override string ToString()
        {
            return String.Format("Course Csci: {0}, Name: {1}, StudentCount: {2}", Csci, Name, StudentCount);
        }

        public int CompareTo(object obj)
        {
            if(this.Csci < ((Course)obj).Csci)
            {
                return -1;
            }
            else if (this.Csci > ((Course)obj).Csci)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
