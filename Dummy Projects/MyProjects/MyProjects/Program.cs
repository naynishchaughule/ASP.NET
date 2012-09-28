using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinqOverStrings();
            //Console.WriteLine();
            //AppExceptions();
            //Console.WriteLine();
            //LazyInstantiation();
            //Console.WriteLine();
            //DeepCopy();
            //Console.WriteLine();
            //ImplementIEnumerable();
            //Console.WriteLine();
            //ConstrainingTypeParameters();
            //Console.WriteLine();
            //EventsAndDelegates();
            //Console.WriteLine();
            //Indexers();
            //Console.WriteLine();
            CustomConversion();
            //Console.WriteLine();
            //ExtensionMethods();
            //Console.WriteLine();
            //OperatorOverloading();
            //Console.WriteLine();
            //ObjectInit();
            Console.ReadLine();
        }

        private static void ObjectInit()
        {
            Worker w = new Worker() { ID = 48090, Name = "nash" };
        }

        private static void OperatorOverloading()
        {
            MyPoint p1 = new MyPoint(10, 20);
            MyPoint p2 = new MyPoint(10, 20);
            p1 += p2;
            p1++;
            Console.WriteLine(p1);
            Console.WriteLine(p1 != p2);
        }

        private static void ExtensionMethods()
        {
            int i = 29;
            i.Display(31);
        }

        private static void CustomConversion()
        {
            //Rectangle r = new Rectangle(20, 10);
            //Square s = (Square)r;
            Square s = new Square(20);
            Rectangle rect = s;
            Console.WriteLine("Rectangle Length: {0}, Height: {1}", rect.length, rect.height);
            //Console.WriteLine("Square: {0}", s.side);

        }

        private static void Indexers()
        {
            Book b1 = new Book(1, "harry potter", "a1");
            Book b2 = new Book(2, "nash", "a2");
            Book b3 = new Book(3, "superman", "a3");
            Library lib = new Library();
            lib.allBooks.Add(b1);
            lib.allBooks.Add(b2);
            lib.allBooks.Add(b3);
            Console.WriteLine(lib[1]);
        }

        private static void EventsAndDelegates()
        {
            EventScheduler sch = new EventScheduler();
            EventListener listener = new EventListener();
            sch.RaiseEvent();
        }

        private static void ConstrainingTypeParameters()
        {
            MyCustomGenericClass<Point> pt = new MyCustomGenericClass<Point>();
            pt.Add(new Point(10, 20));
        }

        private static void ImplementIEnumerable()
        {
            CourseCollection collect = new CourseCollection();
            collect.Add(new Course(456, "S/W Testing", 23));
            collect.Add(new Course(457, "Component Based Ent S/W dev", 12));
            collect.Add(new Course(458, "Open source", 8));
            foreach (KeyValuePair<int, Course> item in collect)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (KeyValuePair<int, Course> item in collect)
            {
                Console.WriteLine(item);
            }
            Course[] arr = new Course[3] { new Course(459, "S/W Testing", 23),
                                           new Course(45, "Component Based Ent S/W dev", 12),
                                           new Course(18, "Open source", 8)                   
                                          };
            Console.WriteLine();
            if (arr[0].CompareTo(arr[1]) == 1)
                Console.WriteLine(arr[0] + " has a higer course id");

            Console.WriteLine();
            //Console.WriteLine("Sort by CSCI");
            //Array.Sort(arr, new SortCourseByCSCI());
            //foreach (Course item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Sort by CSCI");
            Array.Sort(arr, new SortByCourseName());
            foreach (Course item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void DeepCopy()
        {
            Employee emp = new Employee(48090, "naynish", new Manager(32, "Steve Jobs", "Apple"));
            Employee emp1 = (Employee)emp.Clone();
            emp1.manager.MgrID = 65985;
            Console.WriteLine(emp.manager.MgrID);
            Console.WriteLine(emp1.manager.MgrID);           
        }

        private static void LazyInstantiation()
        {
            Catalog IkeaTable = new Catalog(48090, "Ikea - Table");
            Console.WriteLine(IkeaTable.GetCatalogInfo());
            List<Product> prodList = new List<Product>();            
            IkeaTable.AddProductsToCatalog(new Product(1, "table 1", 35, 89));
            IkeaTable.AddProductsToCatalog(new Product(2, "table 2", 67, 36));
            IkeaTable.AddProductsToCatalog(new Product(3, "table 3", 23, 18));
            IkeaTable.AddProductsToCatalog(new Product(4, "table 4", 98, 29));
            IkeaTable.DisplayProducts();
        }

        private static void AppExceptions()
        {
            
        }

        static void LinqOverStrings()
        {
            string s = "sdkjfsdkuuuuuuuiiieiouejfasdfsedfdisfdsfosfsuaaa";
            var result = from item in s
                         where item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u'
                         group item by item into groupedItems
                         select groupedItems;
            foreach (var item1 in result)
            {
                Console.Write(item1.Key + " ");
                Console.WriteLine(item1.Count());
            }
        }
    }
}
