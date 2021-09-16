using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            YahtzeeGame yahtzeeGame1 = new YahtzeeGame();
            yahtzeeGame1.Init();
            PlayYahtzee(yahtzeeGame1);
        }
        void PlayYahtzee(YahtzeeGame game)
        {
            int nrOfAttempts = 0;

            do
            {
                game.Throw();
                game.DisplayValues();
                nrOfAttempts++;
            } while (!game.Yahtzee());

            Console.WriteLine("Number of attempts needed (for Yahtzee): {0}", nrOfAttempts);
        }
    }
}
