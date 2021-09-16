using System;
using System.Collections.Generic;
using System.IO;

namespace assignment4
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
            List<string> words = ReadWords(filename, 5);
            string lingoWord = SelectWord(words);

            LingoGame lingoGame = new LingoGame();
            lingoGame.Init(lingoWord);

            if (PlayLingo(lingoGame))
            {
                Console.WriteLine();
                Console.WriteLine("You have guessed the word");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Too bad, you did not guess the word ({0})", lingoGame.lingoWord);
            }
            Console.ReadLine();
        }
        List<string> ReadWords(string filename, int wordLength)
        {
            List<string> lingoWords = new List<string>();
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                if (wordLength == 5)
                {
                    lingoWords.Add(reader.ReadLine());
                }
            }
            reader.Close();
            return lingoWords;
        }
        string SelectWord(List<string> words)
        {
            Random rnd = new Random();
            int randomWord = rnd.Next(words.Count);
            return words[randomWord].ToLower();
        }
        bool PlayLingo(LingoGame lingoGame)
        {
            int attemptsLeft = 5;
            int wordLength = lingoGame.lingoWord.Length;
            while (attemptsLeft > 0 && !lingoGame.WordGuessed())
            {
                lingoGame.playerWord = ReadPlayerWord(wordLength);
                LingoGame.LetterState[] letterResults = lingoGame.ProcessWord(lingoGame.playerWord);
                DisplayPlayerWord(lingoGame.playerWord, letterResults);

                attemptsLeft -= 1;
            }
            return lingoGame.WordGuessed();
        }
        string ReadString(string question)
        {
            Console.Write(question);
            string name = Console.ReadLine();
            return name;
        }
        string ReadPlayerWord(int length)
        {
            string word;
            do
            {
                Console.WriteLine();
                word = ReadString("Enter a (5-letter) word: ");
                
            } while (word.Length != length);
            return word;
        }
        void DisplayPlayerWord(string playerWord, LingoGame.LetterState[] letterResults)
        {
            for (int i = 0; i < playerWord.Length; i++)
            {
                if (letterResults[i] == LingoGame.LetterState.Correct)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (letterResults[i] == LingoGame.LetterState.WrongPosition)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                Console.Write(playerWord[i]);
                Console.ResetColor();
            }
        }
    }
}
