using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            while(input != "stop")
            {
                int counter = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                    {
                        counter++;
                    }
                }
                Console.WriteLine("This word contains {0} vowels.", counter);
                Console.Write("Enter a word: ");
                input = Console.ReadLine();
            }

            Console.WriteLine("\nend of program");
        }
    }
}
