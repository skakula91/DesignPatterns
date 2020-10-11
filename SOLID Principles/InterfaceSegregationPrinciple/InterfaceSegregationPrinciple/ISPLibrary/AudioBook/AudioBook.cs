using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary
{
    public class AudioBook : IBorrowableAudioBook
    {
        public string Author { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public int CheckoutDuration { get; set; } = 14;
        public string LibraryId { get; set; }
        public int Pages { get; set; } = -1;
        public string Title { get; set; }
        public int RunTimeInMinute { get; set; }
        public void CheckIn()
        {
            Borrower = "";
        }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckoutDuration);
        }
    }
}
