using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.Component
{
    public class Manager : IDirectReport
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public List<IDirectReport> DirectReports;

        public Manager(string name, string department)
        {
            Name = name;
            Department = department;
            DirectReports = new List<IDirectReport>();
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name:{Name},Department:{Department}");
            foreach(var dr in DirectReports)
            {
                dr.GetInfo();
            }
        }
    }
}
