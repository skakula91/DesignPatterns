using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPLibrary;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // ISP- client should not be forced to depend on interfaces they don't use
            IBorrowableDVD dvd = new DVD();

            Console.ReadLine();
        }
    }
}
