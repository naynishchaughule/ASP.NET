using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyProjects
{
    class SortByCourseName : IComparer
    {
        public int Compare(object x, object y)
        {
            if (((Course)x).Name.GetHashCode() < ((Course)y).Name.GetHashCode())
            {
                return -1;
            }
            else if (((Course)x).Name.GetHashCode() > ((Course)y).Name.GetHashCode())
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
