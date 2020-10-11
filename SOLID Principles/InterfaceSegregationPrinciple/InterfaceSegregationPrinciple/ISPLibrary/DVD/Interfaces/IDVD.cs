using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary
{
    public interface IDVD : ILibraryItem
    {
        int RunTimeMinutes { get; set; }
        List<string> Actors { get; set; }
    }
}
