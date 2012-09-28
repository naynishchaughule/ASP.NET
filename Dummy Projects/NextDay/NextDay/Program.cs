using System;
using System.Collections.Generic;
using System.Text;

namespace NextDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Button btn1 = new Button();
            btn1.eve += new Click(btn1_eve);
            btn1.RaiseEvent();
            Console.ReadLine();
        }

        static void btn1_eve(object obj, EventArgs e, string msg)
        {
            Console.WriteLine(((ButtonEvent)e).Id + " " + msg);
        }
    }
}
