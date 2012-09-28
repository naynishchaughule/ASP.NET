using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Home
{
    class Car : IEnumerable, IComparer
    {
        public const int i = 10;
        public Lazy<List<Company>> k = new Lazy<List<Company>>();
        public Lazy<int[]> k = new Lazy<int[]>();               

        string[] arr = new string[] { "Hello", "World", "Naynish"};
        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }

        public int Compare(object x, object y)
        {
            int X = (int)x;
            int Y = (int)y;
            if(X < Y)
            {
                return -1;

            }
            else if (X > Y)
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
