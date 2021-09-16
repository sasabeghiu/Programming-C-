using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            string word2 = "";

            foreach (char c in word)
            {
                word2 = c + word2;
            }

            if (word == word2)
            {
                Console.WriteLine("{0} is a palindrome.", word);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome.", word);
            }
            Console.ReadKey();
        }
    }
}
