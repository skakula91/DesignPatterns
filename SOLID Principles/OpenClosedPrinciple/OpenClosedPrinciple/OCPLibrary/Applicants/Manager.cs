using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class Manager : IApplicationModel
    {
        public string FirstName {get; set; }
        public string LastName { get; set; }
        public IAccountProcessor AccountProcessor { get; set; } = new ManageAccounts();
    }
}
