using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userNr = Int32.Parse(Console.ReadLine());
            double average = 0;
            int counter = 0;

            while (userNr != 0)
            {
                if (userNr > 0)
                {
                    average += userNr;
                    counter++;
                }
                Console.Write("Enter a number: ");
                userNr = Int32.Parse(Console.ReadLine());
            }

            double avg = average / counter;
            Console.WriteLine("Average of all positive numbers is: " +avg.ToString("0.00"));
            Console.ReadLine();
        }
    }
}
