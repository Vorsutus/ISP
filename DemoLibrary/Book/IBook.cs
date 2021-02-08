using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IBook : ILibraryItem
    {
        //These items are exclusive to Books only
        string Author { get; set; } //Everything in the Book section will have an Author
        int Pages { get; set; } //Everything in the Book section will have pages
    }
}
