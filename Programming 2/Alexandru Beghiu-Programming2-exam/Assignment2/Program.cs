using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        const int NrOfRow = 5;
        const int NrOfCol = 5;
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            int[,] bingoCard = new int[NrOfRow, NrOfCol];

            FillBingoCard(bingoCard);
            DisplayBingoCard(bingoCard);
            Console.ReadKey();
        }
        void FillBingoColumn(int[,] bingoCard, int column, int minNumber, int maxNumber)
        {
            List<int> usedNumbers = new List<int>();

            Random rnd = new Random();
            for (int row = 0; row < bingoCard.GetLength(0); row++)
            {
                int number;
                do
                {
                    number = rnd.Next(minNumber, maxNumber + 1);
                }
                while (usedNumbers.Contains(number));

                usedNumbers.Add(number);
                bingoCard[row, column] = number;
            }
        }
        void FillBingoCard(int[,] bingoCard)
        {
            int min = 1;
            int max = 15;
            for (int col = 0; col < bingoCard.GetLength(1); col++)
            {
                FillBingoColumn(bingoCard, col, min, max);
                min += 1;
                max += 15;
            }

            bingoCard[NrOfRow / 2, NrOfCol / 2] = 0;
        }
        void DisplayBingoCard(int[,] bingoCard)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("B  I  N  G  O");
            Console.ResetColor();
            for (int row = 0; row < bingoCard.GetLength(0); row++)
            {
                for (int col = 0; col < bingoCard.GetLength(1); col++)
                {
                    int number = bingoCard[row, col];
                    if (number <= 0)
                        Console.Write("-- ");
                    else
                        Console.Write($"{number,2} ");
                }
                Console.WriteLine();
            }
        }
    }
}
