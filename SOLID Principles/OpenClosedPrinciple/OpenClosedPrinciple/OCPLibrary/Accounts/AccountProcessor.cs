using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class AccountProcessor : IAccountProcessor
    {
        public EmployeeDetailModel Create(IApplicationModel employee)
        {
            EmployeeDetailModel employeeDetail = new EmployeeDetailModel();
            employeeDetail.FirstName = employee.FirstName;
            employeeDetail.LastName = employee.LastName;
            employeeDetail.Email = $"{employee.FirstName}.{employee.LastName}@gmail.com";

            // without ocp
            //if (employee.EmployeeType == EmployeeType.Manager)
            //{
            //    employeeDetail.IsManager = true;
            //}
            return employeeDetail;
        }
    }
}
