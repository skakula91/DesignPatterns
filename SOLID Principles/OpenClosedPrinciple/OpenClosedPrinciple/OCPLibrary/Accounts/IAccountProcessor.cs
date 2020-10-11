using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public interface IAccountProcessor
    {
        EmployeeDetailModel Create(IApplicationModel employee);
    }
}
