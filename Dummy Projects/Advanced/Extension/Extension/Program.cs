using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension
{
    class MyExtension : InterfaceImplementation.IDisplay
    {
        public void Show()
        {
            Console.WriteLine("Extension.MyExtension called...");
        }
    }
}
