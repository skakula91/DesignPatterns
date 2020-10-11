using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }
        // commented stuff doesn't apply to all the class that inherit the interface
        // string Author { get; set; }
        // DateTime BorrowDate { get; set; }
        // string Borrower { get; set; }
        // int CheckoutDuration { get; set; }
        // int Pages { get; set; }
        // void CheckIn();
        // void CheckOut(string borrower);
        // DateTime GetDueDate();
    }
}
