﻿using System;
using System.Collections.Generic;
using System.IO;

namespace assignment2
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
            List<string> words = ListOfWords(filename);
            HangmanGame hangman = new HangmanGame();
            string word = SelectWord(words);
            hangman.Init(word);
            if (PlayHangman(hangman))
            {
                Console.WriteLine();
                Console.WriteLine("You guessed the word!");
            }
            else
            {
                Console.WriteLine("Too bad, you did not guess the word ({0})", hangman.secretWord);
            }
            Console.ReadLine();
        }
        List<string> ListOfWords(string filename)
        {
            List<string> hardcoded = new List<string>();
            StreamReader reader = new StreamReader(filename);
            while(!reader.EndOfStream)
            {
                hardcoded.Add(reader.ReadLine());
            }
            reader.Close();
            return hardcoded;
        }
        string SelectWord(List<string> words)
        {
            Random rnd = new Random();
            int selectedWord = rnd.Next(words.Count);
            while(words[selectedWord].Length <= 3)
            {
                selectedWord = rnd.Next(words.Count);
            }
            return words[selectedWord];
        }
        bool PlayHangman(HangmanGame hangman)
        {
            List<char> enteredLetters = new List<char>();
            DisplayWord(hangman.guessedWord);
            int attempts = 8;
            while (attempts != 0 && !hangman.IsGuessed())
            {
                char letter = ReadLetter(enteredLetters);
                enteredLetters.Add(letter);
                DisplayLetters(enteredLetters);
                if (hangman.ContainsLetter(letter))
                {
                    hangman.ProcessLetter(letter);
                }
                else
                {
                    attempts--;
                }
                Console.WriteLine("Attempts left: {0}", attempts);
                Console.WriteLine();
                DisplayWord(hangman.guessedWord);
            }

            return hangman.IsGuessed();
        }
        void DisplayWord(string word)
        {
            foreach (char c in word)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
        }
        void DisplayLetters(List<char> letters)
        {
            Console.Write("Entered letters: ");
            foreach (char c in letters)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
        }
        char ReadLetter(List<char> blacklistLetters)
        {
            char letter;
            do
            {
                Console.Write("Enter a letter: ");
                letter = Convert.ToChar(Console.ReadLine());
            } while (blacklistLetters.Contains(letter));
            return letter;
        }
    }
}
