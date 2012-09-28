using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyProjects
{
    class Library
    {
        public ArrayList allBooks = new ArrayList();        
        
        public Book this[int index]
        {
            get 
            {
                return (Book)allBooks[index];
            }
            set 
            {
                allBooks[index] = value;
            }
        }
    }
}
