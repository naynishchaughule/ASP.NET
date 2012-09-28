using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyProjects
{
    class SortCourseByCSCI : IComparer
    {
        public int Compare(object x, object y)
        {
            if (((Course)x).Csci < ((Course)y).Csci)
            {
                return -1;
            }
            else if (((Course)x).Csci > ((Course)y).Csci)
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
