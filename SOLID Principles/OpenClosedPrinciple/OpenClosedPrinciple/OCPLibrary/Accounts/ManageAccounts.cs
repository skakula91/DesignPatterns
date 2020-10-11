using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class ManageAccounts : IAccountProcessor
    {
        public EmployeeDetailModel Create(IApplicationModel employee)
        {
            EmployeeDetailModel employeeDetail = new EmployeeDetailModel();
            employeeDetail.FirstName = employee.FirstName;
            employeeDetail.LastName = employee.LastName;
            employeeDetail.Email = $"{employee.FirstName}.{employee.LastName}@csscorp.com";

            employeeDetail.IsManager = true;

            return employeeDetail;
        }
    }
}
