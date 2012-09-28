using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientLib
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            ID = id; Name = name;
        }

        public static void Display(Employee emp)
        {
            Console.WriteLine(emp);
        }

        public override string ToString()
        {
            return String.Format("Employee ID: {0}, Name: {1}", ID, Name);
        }

    }
}
