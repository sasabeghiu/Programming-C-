using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.Write("enter your number of exemption ECs: ");
            int exemption = Int32.Parse(Console.ReadLine());
            Console.Write("enter your total number of ECs (of the first year): ");
            int credits = Int32.Parse(Console.ReadLine());

            int minimum = (60 - exemption);
            double reqMinEC = minimum * 0.75;
            double reqEC = reqMinEC + exemption;

            Console.WriteLine("(minimum required ECs to go to the 2nd year: {0}) ", reqEC);

            if (credits >= reqEC)
            {
                Console.WriteLine("\n{0}, you have enough ECs to go to the 2nd year.", name);
            }
            else
            {
                Console.WriteLine("\n{0}, you don't have enough ECs(yet) to go to the 2nd year.", name);
            }
            Console.ReadKey();
        }
    }
}
