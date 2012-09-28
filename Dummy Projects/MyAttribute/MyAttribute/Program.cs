using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAttribute
{
    [EmployeeDescription(Message = "My first attribute")]
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        
        public void Display()
        {
            Console.WriteLine("Display called");
        }
    }
}
