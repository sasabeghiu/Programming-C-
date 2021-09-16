using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 20;
            int[] array = new int[length];
            Random random = new Random();
            int min = int.MaxValue, max = int.MinValue;
            for (int counter = 0; counter < 100; counter++)
            {
                int n = random.Next(1, 100);
                min = Math.Min(min, n);
                max = Math.Max(max, n);
            }
            Console.WriteLine("minimum value: {0}", min);
            Console.WriteLine("maximum value: {0}", max);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
                if (array[i] <= min + 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (array[i] >= max - 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (array[i] <= min + 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (array[i] >= max - 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();


        }
    }
}
