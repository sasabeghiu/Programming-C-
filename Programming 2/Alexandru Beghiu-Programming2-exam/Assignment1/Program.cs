using System;
using System.Linq;

namespace Assignment1
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
            Console.Write("Enter ISBN number: ");
            string isbn = Console.ReadLine();

            try
            {
                ISBNValidation validation = ValidateISBN(isbn);
                switch (validation)
                {
                    case ISBNValidation.ValidISBN13:
                        Console.WriteLine("Valid ISBN-13 number");
                        break;
                    case ISBNValidation.InvalidISBN:
                        Console.WriteLine("Invalid ISBN number!");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            Console.ReadKey();
        }
        ISBNValidation ValidateISBN(string isbn)
        {
            ISBNValidation result = ISBNValidation.InvalidISBN;

            if (isbn.Length >= 13)
            {
                if (IsValidISBN13(isbn))
                {
                    result = ISBNValidation.ValidISBN13;
                }
            }
            return result;
        }
        bool IsValidISBN13(string isbn)
        {
            isbn = isbn.Replace("-", "");
            if (isbn.Length != 13)
            {
                return false;
            }

            int sum = 0;
            for (int i = 0; i < isbn.Length; i++)
            {
                if ((isbn[i] < '0') || (isbn[i] > '9'))
                {
                    throw new Exception("Invalid isbn character!");
                }

                int digit = isbn[i] - '0';

                if ((i % 2) == 1)
                {
                    digit = digit * 3;
                }

                sum = sum + digit;
            }
            return (sum % 10 == 0);
        }
    }
}
