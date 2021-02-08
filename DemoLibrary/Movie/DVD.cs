using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DVD : IBorrowableDVD
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        //public string Author { get; set; } = ""; //DVD doesn't have this and we shouldn't have an interface to it
        //public int Pages { get; set; } = -1; //DVD doesn't have this and we shouldn't have an interface to it
        public int CheckOutDurationInDays { get; set; } = 14;
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public void CheckIn()
        {
            Borrower = "";
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}
