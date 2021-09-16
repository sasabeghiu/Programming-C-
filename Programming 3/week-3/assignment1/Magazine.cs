using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Magazine : BookStoreItem
    {
        public string ReleaseDay { get; private set; }

        public Magazine(string title, string releaseDay, double price, int count)
            : base(title, price, count)
        {
            this.ReleaseDay = releaseDay;
        }

        public override void Print()
        {
            Console.WriteLine($"[Magazine] {Title} - release day:{ReleaseDay}, {Price:0.00} ({Count}x)");
        }
    }
}
