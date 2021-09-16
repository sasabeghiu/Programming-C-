using System;
using Model;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadLine();
        }
        void Start()
        {
            Customer customer1 = new Customer(1, "Lionel", "Messi", "lionelmessi@hotmail.com");
            Customer customer2 = new Customer(2, "Don", "Henley", "donhenley@gmail.com");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing customers");
            Console.ResetColor();
            Console.WriteLine(customer1.ToString());
            Console.WriteLine(customer2.ToString());
            Console.WriteLine();

            Book book1 = new Book(1, "Harry Potter and the Prisoner of Azkaban", "J.K. Rowling");
            Book book2 = new Book(2, "The Da Vince Code", "Dan Brown");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing books");
            Console.ResetColor();
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book2.ToString());
            Console.WriteLine();

            Reservation reservation1 = new Reservation(1, customer1, book2);
            Reservation reservation2 = new Reservation(2, customer2, book2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing reservations");
            Console.ResetColor();
            Console.WriteLine(reservation1.ToString());
            Console.WriteLine(reservation2.ToString());
            Console.WriteLine();
        }
    }
}
