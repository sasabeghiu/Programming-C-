using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            while (input > 1)
            {
                for (int i = 2; i <= input-1; i++)
                {
                    if(input % i ==0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        i = i + 1;
                    }
                }
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());
            }
            if (input <=1 )
            {
                Console.WriteLine("\nend of program");
            }
            Console.ReadKey();
        }
    }
}
