using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class BookStore
    {
        private List<BookStoreItem> items = new List<BookStoreItem>();
        
        public void Add(BookStoreItem item)
        {
            items.Add(item);
        }

        public void PrintCompleteStock()
        {
            double finalprice = 0;
            foreach (BookStoreItem item in items)
            {
                item.Print();
                finalprice += item.TotalPrice;
            }
            Console.WriteLine($"Total sales price: {finalprice:0.00}");
        }
    }
}
