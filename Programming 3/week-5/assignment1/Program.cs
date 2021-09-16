using System;
using ReservationSystemLogic;
using Model;
using System.Collections.Generic;

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
            TestCustomers();
            TestBooks();
        }

        public void TestCustomers()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing CustomerService");
            Console.ResetColor();
            Console.WriteLine();
            CustomerService cust = new CustomerService();

            Console.Write("Enter customer id: ");
            int value = int.Parse(Console.ReadLine());
            Customer customer1 = cust.GetById(value);
            if (customer1 != null)
            {
                Console.WriteLine(customer1);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"No customer with id {value}");
            }
        }

        public void TestBooks()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing BookService");
            Console.ResetColor();
            Console.WriteLine();
            BookService book = new BookService();

            Console.Write("Enter name of author: ");
            string input = Console.ReadLine();
            List<Book> books = book.GetByAuthor(input);
            foreach (Book b in books)
            {
                Console.WriteLine(b);
            }
        }
    }
}
