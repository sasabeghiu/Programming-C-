using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number:");
            string value1 = Console.ReadLine();
            int nr1 = Int32.Parse(value1);
            Console.Write("Enter second number:");
            string value2 = Console.ReadLine();
            int nr2 = Int32.Parse(value2);
            Console.Write("Enter third number:");
            string value3 = Console.ReadLine();
            int nr3 = Int32.Parse(value3);

            if (nr1 > nr3 && nr2 > nr3)
            {
                Console.WriteLine("The third number is the smallest of the three");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three");
            }

            Console.ReadKey();
        }
    }
}
