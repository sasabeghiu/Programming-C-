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

        void Start()
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            // ... create factory
            ComputerFactory highBugetFactory = new HighBugetFactory();
            // ... create shop
            ComputerShop highBugetShop = new ComputerShop();
            // ... assemble (one) computer
            Computer computer = highBugetShop.AssembleComputer(highBugetFactory);
            // ... test the new computer
            computer.Test();
            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            // ... create factory
            ComputerFactory lowBugetFactory = new LowBugetFactory();
            // ... create shop
            ComputerShop lowBugetShop = new ComputerShop();
            // ... assemble (one) computer
            Computer computer1 = lowBugetShop.AssembleComputer(lowBugetFactory);
            // ... test the new computer
            computer1.Test();
        }

    }
}
