using System;
using System.Collections.Generic;

namespace assignment3
{
    class TicketSystem
    {
        private static TicketSystem uniqueInstance;
        Dictionary<string, int> tickets;

        private TicketSystem()
        {
            tickets = new Dictionary<string, int>();
            tickets.Add("Bruno Mars", 250);
            tickets.Add("Coldplay", 175);
            tickets.Add("Ed Sheeran", 150);
        }

        public static TicketSystem GetUniqueInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new TicketSystem();
            }
            return uniqueInstance;
        }

        public void DisplayAllTickets()
        {
            foreach(KeyValuePair<string, int> kvp in tickets)
            {
                Console.WriteLine($"Artist: {kvp.Key} - nr. of tickets: {kvp.Value}");
            }
            Console.WriteLine();
        }

        public void SellTickets(string artist, int count)
        {
            Console.WriteLine($"selling {count}x tickets for {artist}");
            if (tickets.ContainsKey(artist))
            {
                tickets[artist] -= count;
            }
        }
    }
}
