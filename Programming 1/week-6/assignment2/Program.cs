using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool primeTest = false;
            int number = 1;
            while (number != 0)
            {
                Console.Write("Enter a number (0 is stop value): ");
                number = int.Parse(Console.ReadLine());
                primeTest = PrimeTester(number);

                if (number == 0)
                {
                    Console.WriteLine("end of program");
                    break;
                }
                else if (number < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }

                if (primeTest)
                {
                    Console.WriteLine("{0} is a prime number.", number);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number.", number);
                }
            }
            if (number < 0)
            {
                Console.WriteLine("Negative number entered...");
            }
        }

        static bool PrimeTester(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
