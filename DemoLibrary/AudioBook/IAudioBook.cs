using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //didn't pull from IBorrowable because there may be audiobooks that we can't borrow in the future
    public interface IAudioBook : ILibraryItem
    {
        //This item is exclusive to Audiobooks only
        int RuntimeInMinutes { get; set; }
    }
}
