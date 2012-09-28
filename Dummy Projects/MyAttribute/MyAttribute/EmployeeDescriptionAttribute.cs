using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAttribute
{
    public sealed class EmployeeDescriptionAttribute : System.Attribute
    {
        public string Message { get; set; }

        public EmployeeDescriptionAttribute()
        {
            Message = "null";
        }

        public EmployeeDescriptionAttribute(string msg)
        {
            Message = msg;
        }
    }
}
