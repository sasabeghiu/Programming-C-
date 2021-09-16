using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class WarCardGame : CardGame
    {
        Player player1 = new Player("John");
        Player player2 = new Player("Emma");

        public WarCardGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void StartNewGame()
        {
            deckOfCards.Shuffle();
            int count = 0;
            foreach (PlayingCard card in deckOfCards.allPlayingCards)
            {
                if (count % 2 == 0)
                {
                    player1.AddCard(card);
                }
                else
                {
                    player2.AddCard(card);
                }
                count++;
            }
        }

        public bool EndOfGame()
        {
            if (player1.cards.Count != 0 && player2.cards.Count != 0)
            {
                return false;
            }
            Player winner = new Player("winner");
            if (player1.cards.Count < player2.cards.Count)
            {
                winner = player2;
            }
            else
            {
                winner = player1;
            }
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine($"{winner.name} has won!");
            return true;
        }

        public void NextCard()
        {
            Console.ResetColor();
            Console.WriteLine($"[{player1.name}] {player1.cards[0]} - [{player2.name}] {player2.cards[0]}");
            PlayingCard card1 = player1.GetNextCard();
            PlayingCard card2 = player2.GetNextCard();

            if(card1.rank > card2.rank)
            {
                player1.AddCard(card1);
                player1.AddCard(card2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{player1.name} got the cards");
            }
            else if (card2.rank > card1.rank)
            {
                player2.AddCard(card2);
                player2.AddCard(card1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{player2.name} got the cards");
            }
            else
            {
                player1.cards.Remove(card1);
                player2.cards.Remove(card2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"2 cards lost...\nCards left: [{player1.name}] {player1.cards.Count}x, [{player2.name}] {player2.cards.Count}x");
            }
        }
    }
}
