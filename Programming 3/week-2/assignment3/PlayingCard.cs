using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class PlayingCard
    {
        public int rank;
        public CardSuit suit;

        public PlayingCard(int rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            string rank1 = rank.ToString();
            if (rank == 11)
            {
                rank1 = "Jack";
            }
            else if (rank == 12)
            {
                rank1 = "Queen";
            }
            else if(rank == 13)
            {
                rank1 = "King";
            }
            else if(rank == 14)
            {
                rank1 = "Ace";
            }

            return $"{rank1} of {suit}";
        }
    }
}
