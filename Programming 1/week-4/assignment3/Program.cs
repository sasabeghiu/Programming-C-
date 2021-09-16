using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int sum = 0;

            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            while (number != 0)
            {
                counter++;

                if (number > 0 && number <= 15 && counter % 5 == 0)
                {
                    sum = sum + number;  
                }
                Console.Write("Enter a number: ");
                number = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of 5th, 10th, 15th, ... number is: {0}", sum);
            Console.ReadKey();
        }
    }
}
