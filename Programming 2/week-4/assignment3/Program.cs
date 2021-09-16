using System;
using System.IO;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[2-3] <filename>");
                return;
            }
            string filename = args[0];
            Program myProgram = new Program();
            myProgram.Start(filename);
        }
        void Start(string filename)
        {
            Console.Write("Enter a word (to search): ");
            string input = Console.ReadLine();
            Console.WriteLine("Number of lines containing the word: {0}", SearchWordInFile(filename, input));
            Console.ReadLine();
        }
        bool WordInLine(string line, string word)
        {
            return line.ToLower().Contains(word.ToLower());
        }
        int SearchWordInFile(string filename, string word)
        {
            StreamReader reader = new StreamReader(filename);
            int counter = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (WordInLine(line, word))
                {
                    counter++;
                    DisplayWordInLine(line, word);
                }
            }
            reader.Close();
            return counter;
        }
        void DisplayWordInLine(string line, string word)
        {
            int value = line.ToLower().IndexOf(word.ToLower());
            string substring = line.Substring(value, word.Length);
            Console.Write(line.Substring(0, value));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"[{substring}]");
            Console.ResetColor();
            Console.WriteLine(line.Substring(value + word.Length));

        }
    }
}
