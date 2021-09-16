using System;

namespace Assignment2
{
    class Program
    {
        const int nrOfRows = 6;
        const int nrOfCols = 10;
        const int min = 1;
        const int max = 100;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadLine();
        }

        void Start()
        {
            int[,] matrix = new int[nrOfRows, nrOfCols];
            FillMatrix(matrix, min, max);
            ProcessMatrix(matrix);
            DisplayMatrix(matrix);
        }

        void FillMatrix(int[,] matrix, int min, int max)
        {
            Random rnd = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rnd.Next(min, max);
                }
            }
        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] >= 1 && matrix[row, col] <= 19)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (matrix[row, col] >= 20 && matrix[row, col] <= 39)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (matrix[row, col] >= 40 && matrix[row, col] <= 59)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (matrix[row, col] >= 60 && matrix[row, col] <= 79)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (matrix[row, col] >= 80 && matrix[row, col] <= 99)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    Console.Write("{0:00} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        void HighestDown(int[,] matrix, int column)
        {
            int highestNr = 1;
            int rowNr = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, column] > highestNr)
                {
                    highestNr = matrix[row, column];
                    rowNr = row;
                }

                matrix[rowNr, column] = matrix[matrix.GetLength(0) - 1, column];
                matrix[matrix.GetLength(0) - 1, column] = highestNr;
            }
        }

        void ProcessMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    HighestDown(matrix, col);
                    LowestUp(matrix, col);
                }
            }
        }

        void LowestUp(int[,] matrix, int column)
        {
            int lowestNr = 1;
            int rowNr = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, column] < lowestNr)
                {
                    lowestNr = matrix[row, column];
                    rowNr = row;
                }

                matrix[rowNr, column] = matrix[0, column];
                matrix[0, column] = lowestNr;
            }
        }
    }
}
