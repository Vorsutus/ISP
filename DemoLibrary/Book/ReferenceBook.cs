using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //pulls too much from one interface
    //public class ReferenceBook : ILibraryItem
    //This only pulls the things we need (ISP)
    public class ReferenceBook : IBook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        //All these items are not things that the Reference Books need to have
        //public int CheckOutDurationInDays { get; set; } = 0;
        //public string Borrower { get; set; }
        //public DateTime BorrowDate { get; set; }

        //public void CheckOut(string borrower)
        //{
        //    throw new NotImplementedException();
        //}

        //public void CheckIn()
        //{
        //    throw new NotImplementedException();
        //}

        //public DateTime GetDueDate()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
