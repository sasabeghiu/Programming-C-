using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    //created a new abstract class in order to use it as a base for book and magazine
    abstract class Prints
    {
        public string title;
        public double price;

        public Prints(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public abstract void Print();
    }
}
