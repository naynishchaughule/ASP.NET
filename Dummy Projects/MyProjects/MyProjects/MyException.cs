using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    [System.Serializable]
    public class MyException : System.ApplicationException
    {
        //3 ctors
        public MyException() 
        { 
        
        }
        
        public MyException(string message) : base(message) 
        { 
            
        }

        public MyException(string message, Exception inner) : base(message, inner) 
        { 
            
        }

        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) 
        { 
            
        }
    }   
}
