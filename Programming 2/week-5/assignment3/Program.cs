using System;
using System.Collections.Generic;
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
                Console.WriteLine("usage: assignment[3-4] <filename>");
                return;
            }
            string filename = args[0];
            Program myProgram = new Program();
            myProgram.Start(filename);
        }
        void Start(string filename)
        {
            Dictionary<string, string> words = ReadWords(filename);
            TranslateWords(words);
        }
        Dictionary<string, string> ReadWords(string filename)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            StreamReader reader = new StreamReader(filename);
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                words.Add(line.Split(';')[0], line.Split(';')[1]);
            }
            reader.Close();
            return words;
        }
        void TranslateWords(Dictionary<string, string> words)
        {
            Console.Write("Enter a word: ");
            string dutchword = Console.ReadLine();
            while(dutchword != "stop")
            {
                if(dutchword == "listall")
                {
                    ListAllWords(words);
                }
                else if(words.ContainsKey(dutchword))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} => {1}", dutchword, words[dutchword]);
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine($"word '{dutchword}' not found");
                }
                Console.ResetColor();
                Console.Write("Enter a word: ");
                dutchword = Console.ReadLine();
            }
        }
        void ListAllWords(Dictionary<string, string> words)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (string dutchword in words.Keys)
            {
                Console.WriteLine("{0} => {1}", dutchword, words[dutchword]);
            }
        }
    }
}
