using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        public void Start()
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Customer customer1 = new Customer("Lionel Messi", new DateTime(1987, 06, 24));
            Customer customer2 = new Customer("Piet Paulusma", new DateTime(1956, 12, 15));
            Ticket ticket1 = new Ticket("Bohemian Rapsody", 10.50m);
            Ticket ticket2 = new Ticket("The Prodigy", 10.50m);
            Ticket ticket3 = new Ticket("Green Book", 10.50m);
            ticket1.CinemaRoom = 1;
            ticket2.CinemaRoom = 4;
            ticket3.CinemaRoom = 5;
            ticket1.StartTime = new DateTime(2021, 02, 13, 21, 30, 00);
            ticket2.StartTime = new DateTime(2021, 02, 13, 22, 00, 00);
            ticket3.StartTime = new DateTime(2021, 02, 15, 19, 00, 00); 
            ticket1.MinimumAge = 6;
            ticket2.MinimumAge = 16;
            ticket3.MinimumAge = 12;

            Reservation reservation1 = new Reservation(customer1);
            Reservation reservation2 = new Reservation(customer2);
            
            reservation1.Tickets = new List<Ticket>();
            reservation2.Tickets = new List<Ticket>();

            reservation1.Tickets.Add(ticket1);
            reservation1.Tickets.Add(ticket2);
            reservation1.Tickets.Add(ticket3);

            reservation2.Tickets.Add(ticket1);
            reservation2.Tickets.Add(ticket2);
            reservation2.Tickets.Add(ticket3);

            PrintCustomer(customer1);
            PrintCustomer(customer2);

            Console.WriteLine(reservation1.ToString());
            Console.WriteLine();
            Console.WriteLine(reservation2.ToString());
            Console.ReadLine();
        }

        public void PrintCustomer(Customer customer)
        {
            Console.WriteLine(customer.ToString());
        }
    }
}
