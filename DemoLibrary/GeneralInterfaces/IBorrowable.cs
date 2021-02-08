using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //this Interface is only for Items from the Library that can be borrowed
    //it implements Title and ID from the Library Interface
    public interface IBorrowable : ILibraryItem
    {
        //these are things exclusive to Borrowable Items from the Library
        DateTime BorrowDate { get; set; } //Everything borrowable in the Library will have a Borrow date
        string Borrower { get; set; } //Everything borrowable in the Library will have a Borrower
        int CheckOutDurationInDays { get; set; } //Everything borrowable in the Library will have a CheckOutDurationInDays


        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
