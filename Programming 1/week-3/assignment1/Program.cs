using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //number imput and read
            Console.Write("Enter first number:");
            string value1 = Console.ReadLine();
            int nr1 = Int32.Parse(value1);

            Console.Write("Enter second number:");
            string value2 = Console.ReadLine();
            int nr2 = Int32.Parse(value2);

            Console.ReadLine();

            if (nr1<nr2)
            {
                Console.WriteLine("Highest value is: " + nr2);
                Console.WriteLine("Lowest value is: " + nr1);
            }
            else
            {
                Console.WriteLine("Highest value is: " + nr1);
                Console.WriteLine("Lowest value is: " + nr2);
            }

            Console.ReadKey();
        }
    }
}
