using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 10);

            while (number > 0)
            {
                int result = Factorial(number);
                Console.WriteLine("factorial of {0} is {1}", number, result);
                number = rnd.Next(0, 10);
            }
            Console.WriteLine("\nend of program");
        }

        static int Factorial(int number)
        {
            int fac = 1;
            for (int i = 1; i <= number; i++)
            {
                fac = fac * i;
            }
            return fac;
        }
    }
}
