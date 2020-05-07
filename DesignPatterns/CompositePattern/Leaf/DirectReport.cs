using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.Component
{
    public class DirectReport : IDirectReport
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public DirectReport(string name, string department)
        {
            Name = name;
            Department = department;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name:{Name},Department:{Department}");
        }
    }
}
