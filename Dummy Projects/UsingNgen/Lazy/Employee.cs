using System;
using System.Collections.Generic;
using System.Text;

namespace Lazy1
{
    class Employee
    {
        int Id { get; set; }
        string Fname { get; set; }
        public Lazy<PersonalDetails> Phone = new Lazy<PersonalDetails>();        

        public Employee(int id, string fname)
        {
            Id = id; Fname = fname;
        }

        public string GetFname(int id)
        {
            if (id == this.Id)
            {
                return this.Fname;
            }
            else
                return "Not found";
        }

        public string[] GetStringArrayPersonalDetails()
        {
            PersonalDetails p = Phone.Value;
            return p.phone;
        }
    }
}
