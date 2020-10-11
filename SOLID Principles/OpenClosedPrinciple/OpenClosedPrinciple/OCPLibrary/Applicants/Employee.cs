using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class Employee : IApplicationModel
    {
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public IAccountProcessor AccountProcessor { get; set; }  = new AccountProcessor();
        // without ocp
        //public EmployeeType EmployeeType { get; set; } = EmployeeType.Staff;
    }
}
