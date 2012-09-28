using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoStatic
{
    class Employee
    {
        public static int OrgId { get; set; }
        public static int count;

        //backing variable
        private int id;
        
        //property
        public int Id 
        {
            get
            {                
                return id;
            }

            set
            {
                id = value;             
            }
        }

        static Employee()
        {
            OrgId = 787;
            count = 0;
        }

        public Employee(int id)
        {
            if (id > 100)
            {
                Id = id;
                count++;
            }
        }

        public static void Display()
        {
            Console.WriteLine("public static Display()" + count);
        }
    }
}
