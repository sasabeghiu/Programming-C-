using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadLine();
        }

        void Start()
        {
            Console.Write("Enter a message: ");
            string message = Console.ReadLine();

            Console.Write("Enter a secret key: ");
            string key = Console.ReadLine();

            string result = CreateSubstitutionAlphabet(key, "abcdefghijklmnopqrstuvwxyz");
            string output = ReplaceText(message, "abcdefghijklmnopqrstuvwxyz", result);

            Console.WriteLine($"encrypted message: {output}");
        }

        string CreateSubstitutionAlphabet(string key, string standardAlphabet)
        {
            string alphabetTemp = key + standardAlphabet;
            string substitutionAlphabet = "";

            foreach (char c in alphabetTemp)
            {
                if (!substitutionAlphabet.Contains(c))
                {
                    substitutionAlphabet += c;
                }
            }
            return substitutionAlphabet;
        }

        string ReplaceText(string input, string standardAlphabet, string substitutionAlphabet)
        {
            string output = "";
            foreach (char c in input)
            {
                int position = standardAlphabet.IndexOf(c, 0); //c is a char that we are looking for, and 0 is startindex
                if (position < 0)
                {
                    output += c;
                }
                else
                {
                    output += substitutionAlphabet[position];
                }
            }
            return output;
        }
    }
}
