using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        private void Start()
        {
            //singleton pattern
            TicketSystem ticket1 = TicketSystem.GetUniqueInstance();
            TicketSystem ticket2 = TicketSystem.GetUniqueInstance();

            ticket1.DisplayAllTickets();
            ticket2.SellTickets("Bruno Mars", 50);
            ticket2.SellTickets("Coldplay", 25);
            ticket2.SellTickets("Ed Sheeran", 50);
            Console.WriteLine();
            ticket1.DisplayAllTickets();
        }
    }
}
