using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAdd
{
    class Employee : ISalaryCalc
    {
        double salary;

        public void SumSalary(Employee e1, Employee e2)
        {
            Console.WriteLine(e1.salary + e2.salary);
        }
    }
}
