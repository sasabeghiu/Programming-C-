using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Magazine : Prints
    {
        public string releaseDay;

        public Magazine(string title, string releaseDay, double price)
            :base(title, price)
        {
            this.releaseDay = releaseDay;
        }

        public override void Print()
        {
            Console.WriteLine($"[Magazine] {title} - release day:{releaseDay}, {price:0.00}");
        }
    }
}
