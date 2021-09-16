using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNr = new int[20];
            int i = 0;
            for (; i < inputNr.Length; i++)
            {
                Console.Write("Enter a number (0=stop): ");
                inputNr[i] = int.Parse(Console.ReadLine());
                if (inputNr[i] == 0)
                {
                    break;
                }
            }
            Console.WriteLine("");
            Console.Write("Enter a searchvalue: ");
            int searchNr = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int l = 0; l <= i; l++)
            {
                if (inputNr[l] == searchNr)
                {
                    counter++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Number of occurences of searchvalue ({0}) is: {1}", searchNr, counter);
            Console.ReadKey();
        }
    }
}
