using System;

namespace Assignment3
{
    class Program
    {
        const int ARRAY_SIZE = 20;
        static void Main(string[] args)
        {
            int[] numbers = new int[ARRAY_SIZE];
            Random rnd = new Random();
            int sum = 0;
            int average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int value = rnd.Next(1, 100);
                numbers[i] = value;
                sum += numbers[i];
            }
            average = sum / ARRAY_SIZE;
            Console.WriteLine("average value: "+ average);
            for (int i = 0; i < numbers.Length; i++)
            {
                int value = numbers[i];
                if (value == average)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (value > average)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0:00} ", numbers[i]);
                Console.ResetColor();
            }
        }
    }
}
