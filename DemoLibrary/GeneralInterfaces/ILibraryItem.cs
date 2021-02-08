using System;

namespace DemoLibrary
{
    //this is the base Library Interface
    public interface ILibraryItem
    { 
        string LibraryId { get; set; } //Everything in the Library will have this
        string Title { get; set; } //Everything in the Library will have this

        //string Author { get; set; } //NOT everything in the Library will have an Author (DVDs)
        //DateTime BorrowDate { get; set; } //NOT everything in the Library will have a Borrow date (Ref books)
        //string Borrower { get; set; } //NOT everything in the Library will have a Borrower (Ref Books)
        //int CheckOutDurationInDays { get; set; } //NOT everything in the Library will have a CheckOutDurationInDays (Ref Books)
        //int Pages { get; set; } //NOT everything in the Library will have pages (Audio books)


        //Not all items in the Library will have any of this stuff
        //void CheckIn();
        //void CheckOut(string borrower);
        //DateTime GetDueDate();
    }
}