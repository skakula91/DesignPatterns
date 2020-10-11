using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class ExecutiveAccount : IAccountProcessor
    {
        public EmployeeDetailModel Create(IApplicationModel employee)
        {
            EmployeeDetailModel employeeDetail = new EmployeeDetailModel();
            employeeDetail.FirstName = employee.FirstName;
            employeeDetail.LastName = employee.LastName;
            employeeDetail.Email = $"{employee.FirstName}.{employee.LastName}@csscorpexe.com";

            employeeDetail.IsManager = false;
            employeeDetail.IsExecutive = true;

            return employeeDetail;
        }
    }
}
