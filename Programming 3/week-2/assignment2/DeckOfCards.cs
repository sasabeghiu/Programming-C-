using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class DeckOfCards 
    {
        List<PlayingCard> allPlayingCards = new List<PlayingCard>();

        void InitCards()
        {
            for (int i = 2; i <= 14; i++)
            {
                PlayingCard playingCard = new PlayingCard(i, CardSuit.Spades);
                allPlayingCards.Add(playingCard);
            }
            for (int i = 2; i <= 14; i++)
            {
                PlayingCard playingCard = new PlayingCard(i, CardSuit.Clubs);
                allPlayingCards.Add(playingCard);
            }
            for (int i = 2; i <= 14; i++)
            {
                PlayingCard playingCard = new PlayingCard(i, CardSuit.Hearts);
                allPlayingCards.Add(playingCard);
            }
            for (int i = 2; i <= 14; i++)
            {
                PlayingCard playingCard = new PlayingCard(i, CardSuit.Diamonds);
                allPlayingCards.Add(playingCard);
            }
        }

        public DeckOfCards()
        {
            InitCards();
        }

        public void Print()
        {
            foreach(PlayingCard card in allPlayingCards)
            {
                Console.WriteLine(card);
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int playingCard1 = rnd.Next(allPlayingCards.Count);
                int playingCard2 = rnd.Next(allPlayingCards.Count);
                PlayingCard temporary = allPlayingCards[playingCard1];
                allPlayingCards[playingCard1] = allPlayingCards[playingCard2];
                allPlayingCards[playingCard2] = temporary;
            }

        }
    }
}

