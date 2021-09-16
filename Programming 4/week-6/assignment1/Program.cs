using System;

namespace assignment1
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
            // ... create shop
            ComputerShop highBugetShop = new HighBugetShop();
            // ... assemble (one) computer
            Computer highBugetComputer = highBugetShop.AssembleComputer();
            // ... test the new computer
            highBugetComputer.Test();
            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            // ... create shop
            ComputerShop lowBugetShop = new LowBugetShop();
            // ... assemble (one) computer
            Computer lowBugetComputer = lowBugetShop.AssembleComputer();
            // ... test the new computer
            lowBugetComputer.Test();
        }
    }
}
