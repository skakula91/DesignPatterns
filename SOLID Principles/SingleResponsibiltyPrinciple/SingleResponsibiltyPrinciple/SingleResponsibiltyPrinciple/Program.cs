using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibiltyPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Without SRP
            //Console.WriteLine("Test Application");

            //Employee employee = new Employee();
            //Console.WriteLine("Enter userName");
            //employee.UserName = Console.ReadLine();
            //Console.WriteLine("Enter LastName");
            //employee.LastName = Console.ReadLine();
            //employee.Id = new Random().Next(1,1000);

            //if (string.IsNullOrEmpty(employee.UserName))
            //{
            //    Console.WriteLine("Invalid userName");
            //    Console.ReadLine();
            //    return;
            //}

            //if (string.IsNullOrEmpty(employee.LastName))
            //{
            //    Console.WriteLine("Invalid LastName");
            //    Console.ReadLine();
            //    return;
            //}


            //Console.WriteLine($"you details are {employee.LastName}{employee.UserName}");
            //Console.ReadLine();

            // After restructuring to use SRP
            StandardMessages.StartMessage();
            Employee emp = GetEmployeeData.CaptureData();
            bool isValidEmp = ValidateEmployee.Validate(emp);
            if (!isValidEmp)
            {
                StandardMessages.EndApp();
                return;
            }
            Login.Create(emp);

            StandardMessages.EndApp();
        }
    }
}
