using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary
{
    public class ReferenceBook : IBook // ILibraryItem
    {
        public string Author { get; set; }
        //public DateTime BorrowDate { get; set; }
        //public string Borrower { get; set; }
        //public int CheckoutDuration { get; set; } = 0;
        public string LibraryId { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }
        //public void CheckIn()
        //{
        //    throw new NotImplementedException();
        //}

        //public void CheckOut(string borrower)
        //{
        //    throw new NotImplementedException();
        //}

        //public DateTime GetDueDate()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
