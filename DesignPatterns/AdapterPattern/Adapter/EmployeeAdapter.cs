using DesignPatterns.AdapterPattern.Adaptee;
using DesignPatterns.AdapterPattern.Target;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DesignPatterns.AdapterPattern.Adapter
{
    public class EmployeeAdapter :EmployeeManager,IEmployee
    {
        public override string GetEmployees()
        {
            string xmlData =  base.GetEmployees();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlData);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
