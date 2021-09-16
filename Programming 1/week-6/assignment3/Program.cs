using System;

namespace assignment3
{
    class Program
    {
        bool Leap(int year)
        {
            if (((year % 4) == 0) || ((year % 400) == 0) || ((year % 100) == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void IsLeapYear()
        {
            Console.Write("Enter a year (0 is stop value): ");
            int year = Int32.Parse(Console.ReadLine());
            while (year != 0)
            { 
            if (Leap(year) == true)
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
                {
                Console.WriteLine("{0} is not a leap year.", year);
                }
                Console.Write("Enter a year (0 is stop value): ");
                year = Int32.Parse(Console.ReadLine());

            }
            if (year == 0)
            {
                Console.WriteLine("end of program.");
            }
        }
        static void Main(string[] args)
        {
            Program ex = new Program();
            ex.IsLeapYear();
            Console.ReadKey();
        }
    }
}
