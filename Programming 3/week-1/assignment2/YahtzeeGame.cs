using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class YahtzeeGame
    {
        //e - array dices and methot to create all dices
        Dice[] dices = new Dice[5];
        public YahtzeeGame()
        {
            Random rnd = new Random();
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = new Dice(rnd);
            }
        } 
        
        //f-method to throw all dices
        public void Throw()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].Throw();
            }
        }
        //g-display all values
        public void DisplayValues()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].DisplayValue();
            }
            Console.WriteLine("");//i put this here to show each 5 throws in a row
        }
        //i - returning true of false depending on if dices have the same value
        public bool Yahtzee()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[0].value != dices[i].value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
