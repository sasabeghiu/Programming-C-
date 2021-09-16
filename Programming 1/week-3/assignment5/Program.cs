using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string value1 = Console.ReadLine();
            int nr1 = Int32.Parse(value1);
            Console.Write("Enter second number: ");
            string value2 = Console.ReadLine();
            int nr2 = Int32.Parse(value2);

            if (nr1 % nr2 == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else if (nr2 % nr1 == 0)
            {
                Console.WriteLine("Number 2 is multiple of number 1");
            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }
            Console.ReadLine();
        }
    }
}
