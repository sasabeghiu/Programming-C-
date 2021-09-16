using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace assignment2
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
            CustomerDAO customerDAO = new CustomerDAO();
            //get all customers
            List<Customer> customers = customerDAO.GetAll();
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
            //by id
            Console.WriteLine();
            Console.Write("Enter customer id: ");
            int value = int.Parse(Console.ReadLine());

            Customer customer1 = customerDAO.GetById(value);
            if (customer1 != null)
            {
                Console.WriteLine(customer1);
            }
            else
            {
                Console.WriteLine($"No customer with id {value}");
            }


            BookDAO bookDAO = new BookDAO();
            // get all books
            List<Book> books = bookDAO.GetAll();
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            //by id
            Console.WriteLine();
            Console.Write("Enter book id: ");
            int value1 = int.Parse(Console.ReadLine());

            Book book1 = bookDAO.GetById(value1);
            if (book1 != null)
            {
                Console.WriteLine(book1);
            }
            else
            {
                Console.WriteLine($"No book with id {value1}");
            }
        }
    }
}
