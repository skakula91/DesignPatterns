using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPLibrary;

namespace OpenClosedPrinciple
{
    class Program
    {
        // OCP: classes should be closed for modification open for extensions
        static void Main(string[] args)
        {
            List<IApplicationModel> employees = new List<IApplicationModel>();
            employees.Add(new Employee(){FirstName = "sai", LastName = "akula"});
            employees.Add(new Employee() { FirstName = "test", LastName = "test1"});
            employees.Add(new Executive() { FirstName = "test2", LastName = "test2" });
            employees.Add(new Manager() { FirstName = "test3", LastName = "test4" });

            List<EmployeeDetailModel> details = new List<EmployeeDetailModel>();
            foreach (var emp in employees)
            {
                details.Add(emp.AccountProcessor.Create(emp));
            }

            foreach (var detail in details)
            {
                Console.WriteLine($"{detail.LastName}{detail.LastName}:{detail.Email},IsManager:{detail.IsManager},IsExecutive:{detail.IsExecutive}");   
            }

            Console.ReadLine();
        }
    }
}
