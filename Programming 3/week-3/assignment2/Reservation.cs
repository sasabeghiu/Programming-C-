using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Reservation
    {
        private decimal totalprice;
        public Customer Customer { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Reservation(Customer customer)
        {
            this.Customer = customer;
        }

        public decimal Totalprice
        {
            get
            {
                foreach (Ticket ticket in Tickets)
                {
                    if (Customer.Age > ticket.MinimumAge)
                    {
                        if (ticket.Discount)
                        {
                            decimal discount = ticket.Price * 0.05M;
                            totalprice += ticket.Price - discount;
                        }
                        else
                        {
                            totalprice += ticket.Price;
                        }
                    }
                }
                if (Customer.Discount)
                {
                    decimal discount = totalprice * 0.1M;
                    totalprice -= discount;
                }
                return totalprice;
            }
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"creating tickets (for {Customer.Name})");
            Console.ResetColor();
            foreach (Ticket ticket in Tickets)
            {
                Console.WriteLine(ticket.ToString());
            }
            return $"total price of reservation: {Totalprice:0.00}";
        }
    }
}
