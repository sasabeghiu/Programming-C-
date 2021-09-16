using System;

namespace assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading the numbers and convert them
            Console.Write("Enter number of working hours: ");
            string value1 = Console.ReadLine();
            int hours = Int32.Parse(value1);
            Console.Write("Enter number of years: ");
            string value2 = Console.ReadLine();
            int years = Int32.Parse(value2);
            Console.Write("Enter number of failures: ");
            string value3 = Console.ReadLine();
            int fails = Int32.Parse(value3);
            Console.ReadLine();

            if (hours>10000)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            else if (years>7)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            else if (fails>25)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced.");
            }

            Console.ReadLine();
        }
    }
}
