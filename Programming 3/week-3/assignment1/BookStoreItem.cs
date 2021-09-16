using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    abstract class BookStoreItem
    {
        private string title;
        private double price;
        private int count;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Count
        {
            get { return count; }
            set
            {
                if (value >= 0)
                    count = value;
            }
        }
        public double TotalPrice
        {
            get { return Price * Count; }
        }

        public BookStoreItem(string title, double price, int count)
        {
            this.Title = title;
            this.Price = price;
            this.Count = count;
        }

        public abstract void Print();
    }
}
