using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibiltyPrinciple
{
    public class Login
    {
        public static void Create(Employee employee)
        {
            Console.WriteLine($"you details are {employee.LastName}{employee.UserName}");
        }
    }
}
