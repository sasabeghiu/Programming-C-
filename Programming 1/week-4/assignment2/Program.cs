using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter target number: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            
            int counter = 0;

            while (input != 0)
            {
                if (input == target)
                {
                    counter++;
                }
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Count of numbers equal to target number: " + counter);
            Console.ReadKey();
        }
    }
}
