using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int input = Int32.Parse(Console.ReadLine());

            while (input != 0)
            {
                if((input % 4) ==0)
                {
                    Console.WriteLine("{0} is a leap year.", input);
                }
                else if ((input % 400) == 0)
                {
                    Console.WriteLine("{0} is a leap year.", input);
                }
                else if (input < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year.", input);
                }
                Console.Write("Enter a year: ");
                input = Int32.Parse(Console.ReadLine());
            }            
            Console.ReadKey();
        }
    }
}
