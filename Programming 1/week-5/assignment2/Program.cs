using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listNumbers = new int[20];
            Random random = new Random(); 
            for (int i = 0; i < listNumbers.Length; i++)
            {
                listNumbers[i] = random.Next(0, 150);
            }
            for (int i = 0; i < listNumbers.Length; i++)
            {
                Console.WriteLine("Element {0} = {1}", i , listNumbers[i]);
            }
            int smallest = listNumbers[0];                
            int a = 0;
            for (int i = 0; i < listNumbers.Length; i++)
            {
                if (listNumbers[i] < smallest)
                { 
                    smallest = listNumbers[i];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("smallest number = " + smallest);
            Console.WriteLine("number of occurence = "+a);
            Console.ReadKey();
        }
    }
}
