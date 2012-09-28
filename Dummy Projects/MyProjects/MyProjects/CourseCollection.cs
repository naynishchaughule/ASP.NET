using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyProjects
{
    class CourseCollection : IEnumerable
    {
        SortedList<int, Course> myCourses = new SortedList<int, Course>();

        public void Add(Course crs)
        {
            myCourses.Add(crs.Csci, crs);
        }

        public void Remove(Course crs)
        {
            if(myCourses.ContainsKey(crs.Csci)) 
                myCourses.Remove(crs.Csci);
        }

        public void DisplayCourseDetails(Course crs)
        {
            if (myCourses.ContainsKey(crs.Csci))
                Console.WriteLine(crs);
        }

        public IEnumerator GetEnumerator()
        {            
            return myCourses.GetEnumerator();
        }

        public IEnumerable CustomGetEnumerator()
        {
            foreach (KeyValuePair<int, Course> item in myCourses)
            {
                yield return item.Value;
            }            
        }
    }
}
