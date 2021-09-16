using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = Int32.Parse(Console.ReadLine());

            while (input > 0)
            {
                for (int i = 0; i < input / 2; i++)
                {
                    Console.Write("*");
                }
                for (int i = input / 2; i < input; i++)
                {
                    Console.Write("!");
                }
                Console.WriteLine();

                Console.Write("Enter a number: ");
                input = Int32.Parse(Console.ReadLine());
            }
            if (input <= 0) 
            {
                Console.WriteLine("end of program");
            }
            Console.ReadKey();
        }
    }
}
