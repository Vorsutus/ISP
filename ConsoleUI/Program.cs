using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //the interface is the variable type not the actual implementation
            //the interface limits you to only what is in the interface contract (only what you need)
            IBorrowableDVD dvd = new DVD();

            Console.ReadLine();
        }
    }
}
