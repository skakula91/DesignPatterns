using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatterns.AdapterPattern.Adaptee
{
    [Serializable]
    public class Employee
    {
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        Employee()
        {

        }
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
    public class EmployeeManager
    {
        public List<Employee> employee;
        public EmployeeManager()
        {
            employee = new List<Employee>();
            this.employee.Add(new Employee(1, "sai1"));
            this.employee.Add(new Employee(2, "sai2"));
            this.employee.Add(new Employee(3, "sai3"));
        }

        public virtual string GetEmployees()
        {
            var nspaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty});
            var serializer = new XmlSerializer(employee.GetType());
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, employee, nspaces);
                return stream.ToString();
            }
        }
    }
}
