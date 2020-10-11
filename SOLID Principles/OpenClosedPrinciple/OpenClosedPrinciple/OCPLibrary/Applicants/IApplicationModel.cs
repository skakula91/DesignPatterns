using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public interface  IApplicationModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccountProcessor AccountProcessor { get; set; }
    }
}
