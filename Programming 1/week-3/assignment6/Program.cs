using System;

namespace assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading the numbers and convert them
            Console.Write("Enter score: ");
            string value = Console.ReadLine();
            int grade = Int32.Parse(value);
            Console.WriteLine();

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("grade: A");
                Console.WriteLine("course passed");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("grade: B");
                Console.WriteLine("course passed");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("grade: C");
                Console.WriteLine("course passed");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("grade: D");
                Console.WriteLine("course not passed");
            }
            else if (grade >= 0 && grade <= 59)
            {
                Console.WriteLine("grade: F");
                Console.WriteLine("course not passed");
            }
            else
            {
                Console.WriteLine("introduce a valid score");
            }

            Console.ReadKey();
        }
    }
}
