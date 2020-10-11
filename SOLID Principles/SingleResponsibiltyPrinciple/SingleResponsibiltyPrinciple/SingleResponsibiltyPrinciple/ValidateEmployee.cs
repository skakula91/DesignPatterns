using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibiltyPrinciple
{
    public class ValidateEmployee
    {
        public static bool Validate(Employee employee)
        {
            if (string.IsNullOrEmpty(employee.UserName))
            {
                Console.WriteLine("Invalid userName");
                StandardMessages.EndApp();
                return false;
            }

            if (string.IsNullOrEmpty(employee.LastName))
            {
                Console.WriteLine("Invalid LastName");
                StandardMessages.EndApp();
                return false;
            }

            return true;
        }
    }
}
