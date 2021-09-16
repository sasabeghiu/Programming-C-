using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class HangmanGame
    {
        public string secretWord;
        public string guessedWord;
        public void Init(string secretWord)
        {
            this.secretWord = secretWord;
            for (int i = 0; i < secretWord.Length; i++)
            {
                guessedWord += "."; //add a dot for each letter
            }
        }
        public bool ContainsLetter(char letter)
        {
            return (secretWord.Contains(letter));
        }
        public void ProcessLetter(char letter)
        {
            char[] secretArray = secretWord.ToCharArray();
            char[] guessedArray = guessedWord.ToCharArray();
            for (int i = 0; i < guessedArray.Length; i++)
            {
                if (letter == secretArray[i])
                {
                    guessedArray[i] = letter;
                }
            }
            guessedWord = new string(guessedArray);
        }
        public bool IsGuessed()
        {
            return (guessedWord == secretWord);
        }
    }
}
