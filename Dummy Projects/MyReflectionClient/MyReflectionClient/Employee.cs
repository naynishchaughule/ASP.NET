using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyReflectionClient
{
    class Employee : IComparable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int x;

        public Employee()
        {

        }

        public Employee(int id, string name, double salary)
        {
            ID = id; Name = name; Salary = salary;
        }        

        public override string ToString()
        {
            return String.Format("Employee ID: {0}, Name: {1}, Salary: {2}", ID, Name, Salary);
        }

        public void Display()
        {
            Console.WriteLine(this);
        }

        public void Add(int x, int y)
        {
            Console.WriteLine("Sum: {0}", x + y);
        }

        public int CompareTo(object obj)
        {
            Console.WriteLine("CompareTo called");
            return 0;
        }
    }
}
