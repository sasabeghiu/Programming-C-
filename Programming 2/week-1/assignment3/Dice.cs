using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class Dice
    {
        //a - class dice
        public int value;
        static Random rnd = new Random();
        //b - method to throw random values
        public void Throw()
        {
           value = rnd.Next(1, 7); //between 1 and 6
        }
        //c - display values
        public void DisplayValue()
        {
            Console.Write("{0} ",value);
        }
    }
}
