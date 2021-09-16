using System;

namespace assignment2
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
            //abstract factory templatE??
            PrintHeader("MacBook");
            Laptop macBook = new MacBook("A1287");
            macBook.Execute("virusscanner.exe");

            PrintHeader("HP");
            Laptop hp = new HPLaptop("S/N 893419");
            hp.Execute("virusscanner.exe");

            PrintHeader("changed MacBook");
            macBook.Processor = Processors.Intel_i7;
            macBook.Execute("virusscanner.exe");
        }

        private void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
