using System;
using System.Collections.Generic;
using System.Text;

namespace Home
{
    [System.Serializable]
    public class MyException : System.ApplicationException
    {
        public MyException() 
        { 
            //default
        }

        public MyException(string message) : base(message) 
        { 
            //ctor that sets the inherited message property
        }

        public MyException(string message, Exception inner) : base(message, inner) 
        { 
            //ctor to handle inner exceptions
        }

        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) 
        { 
            
        }
    }
}
