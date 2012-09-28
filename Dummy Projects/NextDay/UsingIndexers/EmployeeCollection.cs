using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace UsingIndexers
{
    class EmployeeCollection : IEnumerable
    {
        ArrayList empList = new ArrayList();
        int id;
        public Employee this[int index]
        {
            get 
            {
                return (Employee)empList[index];                
            }
            set 
            {
                empList.Add(value);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return empList.GetEnumerator();
        }
    }
}
