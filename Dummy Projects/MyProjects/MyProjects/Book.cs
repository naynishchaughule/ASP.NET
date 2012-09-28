using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class Book
    {
        int ID { get; set; }
        string Name { get; set; }
        string Author { get; set; }

        public Book(int id, string name, string author)
        {
            ID = id; Name = name; Author = author;
        }

        public override string ToString()
        {
            return String.Format("Book ID: {0}, Name: {1}, Author: {2}", ID, Name, Author);
        }
    }
}
