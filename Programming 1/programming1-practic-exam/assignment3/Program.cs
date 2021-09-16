using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[20];
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            int nrWords = 0;
            while ((word.Length != 0) && (nrWords < words.Length))
            {
                words[nrWords] = word;
                nrWords++;

                Console.Write("Enter a word: ");
                word = Console.ReadLine();
            }

            for (int i = 0; i < nrWords; i++)
            {
                string nextWord = words[i];
                if (nextWord.Length % 2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(nextWord);
            }
            Console.ResetColor();
            Console.WriteLine("\nend of program");
        }
    }
}
