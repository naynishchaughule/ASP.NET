using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreadingBasics
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        private object obj = new object();

        public Employee(int id, string name, double sal)
        {
            ID = id; Name = name; Salary = sal;
        }

        public override string ToString()
        {
            return String.Format("Employee ID: {0}, Name: {1}, Salary: {2}", ID, Name, Salary);
        }

        public void Display(object emp)
        {
            lock (obj)
            {
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine(((Employee)emp));
                ThreadingDemo.waitHandle.Set(); 
            }
        }
    }
}
