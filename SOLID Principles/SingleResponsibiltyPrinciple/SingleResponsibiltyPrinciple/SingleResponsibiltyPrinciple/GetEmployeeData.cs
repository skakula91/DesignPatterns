using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibiltyPrinciple
{
    public class GetEmployeeData
    {
        public static Employee CaptureData()
        { 
            Employee employee = new Employee();
            Console.WriteLine("Enter userName");
            employee.UserName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            employee.LastName = Console.ReadLine();
            employee.Id = new Random().Next(1, 1000);

            return employee;
        }
    }
}
