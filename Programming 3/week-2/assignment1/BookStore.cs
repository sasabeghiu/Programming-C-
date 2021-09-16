using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class BookStore
    {
        List<Prints> prints = new List<Prints>();

        public virtual void Add(Prints print)
        {
            prints.Add(print);
        }   

        public void PrintCompleteStock()
        {
            double finalprice = 0;
            foreach(Prints print in prints)
            {
                print.Print();
                finalprice += print.price;
            }
            Console.WriteLine($"Total sales price: {finalprice:0.00}");
        }
    }
}
