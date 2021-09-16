using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Dice
    {
        public int value;
        Random rnd = new Random();
        public Dice(Random rnd)
        {
            this.rnd = rnd;
        }
        public void Throw()
        {
            value = rnd.Next(1, 7);
        }
        public void DisplayValue()
        {
            Console.Write("{0} ", value);
        }

    }
}
