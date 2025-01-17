﻿using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class Player
    {
        public string name;
        public List<PlayingCard> cards = new List<PlayingCard>();

        public Player(string name)
        {
            this.name = name;
            this.cards = new List<PlayingCard>();
        }

        public void AddCard(PlayingCard card)
        {
            cards.Add(card);
        }

        public PlayingCard GetNextCard()
        {
            PlayingCard playingCard = cards[0];
            cards.Remove(cards[0]);
            return playingCard;
        }
    }
}
