using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace assignment1
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
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Book book1 = new Book("Dracula", "Bram Stoker", 15);
            Book book2 = new Book("Joe speedboot", "Tommy Wieringa", 12.5);
            Book book3 = new Book("The hobbit", "J.R.R. Tolkien", 12.5);
            Magazine magazine1 = new Magazine("Time", "Friday", 3.90);
            Magazine magazine2 = new Magazine("Donald Duck", "Thursday", 2.50);

            BookStore bookStore = new BookStore();
            bookStore.Add(book1);
            bookStore.Add(book2);
            bookStore.Add(magazine1);
            bookStore.Add(magazine2);
            bookStore.Add(book3);

            bookStore.PrintCompleteStock();
            Console.ReadKey();


        }
    }
}
