using System;
using System.Collections.Generic;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            List<string> words = ListOfWords();
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
        List<string> ListOfWords()
        {
            List<string> hardcoded = new List<string>();
            hardcoded.Add("airplane"); hardcoded.Add("kitchen"); hardcoded.Add("building"); hardcoded.Add("incredible");
            hardcoded.Add("funny"); hardcoded.Add("trainstation"); hardcoded.Add("neighbour"); hardcoded.Add("different");
            hardcoded.Add("department"); hardcoded.Add("planet"); hardcoded.Add("presentation"); hardcoded.Add("embarrasment");
            hardcoded.Add("integration"); hardcoded.Add("scenario"); hardcoded.Add("discount"); hardcoded.Add("management");
            hardcoded.Add("understanding"); hardcoded.Add("registration"); hardcoded.Add("security"); hardcoded.Add("language");
            return hardcoded;
        }
        string SelectWord(List<string> words)
        {
            Random rnd = new Random();
            int selectedWord = rnd.Next(words.Count);
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
