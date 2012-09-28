using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.EnterpriseServices.Internal;

namespace GacInstall
{
    class Program
    {
        static void Main(string[] args)
        {
            Publish p = new Publish();
            p.GacInstall(@"C:\Users\naynish\Desktop\Dummy Projects\GacInstall\CustomCalcLibrary.dll");
            Console.WriteLine("Installed to Global Assembly Cache");            
            Console.ReadLine();
        }
    }
}
