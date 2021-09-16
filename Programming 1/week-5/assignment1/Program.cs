using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listNumbers = new int[20];
            double avg = 0;
            double sum = 0;
            Random random = new Random();
            for (int i = 0; i < listNumbers.Length; i++)
            {
                listNumbers[i] = random.Next(0, 200);
            }
            for (int i = 13; i < listNumbers.Length; i++)
            {
                Console.WriteLine("Element " + i + " is " + listNumbers[i]);
            }
            for (int i = 0; i < listNumbers.Length; i++)
            {
                sum += listNumbers[i];
                avg = sum / i;
            }
            Console.WriteLine("");
            Console.WriteLine("The average is: " + avg.ToString("0.00"));
            Console.WriteLine("");
            for (int i = 0; i < listNumbers.Length; i++)
            {
                double diff = avg - listNumbers[i];
                Console.WriteLine("Difference between average and element " + i + " is " + Math.Abs(diff).ToString("0.00"));
            }
            Console.ReadKey();
        }
    }
}
