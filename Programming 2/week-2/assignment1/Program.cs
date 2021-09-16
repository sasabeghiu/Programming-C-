using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[1-3] <nrOfRows> <nrOfColumns>");
                return;
            }
            int nrOfRows = int.Parse(args[0]);
            int nrOfColumns = int.Parse(args[1]);
            Program myProgram = new Program();
            myProgram.Start(nrOfRows, nrOfColumns);
        }
        void Start(int nrOfRows, int nrOfColumns)
        {
            int[,] matrix = new int[nrOfRows, nrOfColumns];
            //InitMatrix2D(matrix);
            //DisplayMatrix(matrix);
            InitMatrixLinear(matrix);
            DisplayMatrixWithCross(matrix);
            Console.ReadLine();
        }
        //filling the matrix
        void InitMatrix2D(int[,] matrix)
        {
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    count++;
                    matrix[row, col] = count; //consecutive numbers
                }
            }
        }
        //displaying the matrix
        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine("");
            }
        }
        //fill in the matrix using one loop
        void InitMatrixLinear(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for (int i = 0; i < row * col; i++)
            {
                matrix[i / col, i % col] = i + 1;
            }
        }
        //display matrix with colors on diagonals (not working if rows=8 cols=10, should be equal)
        void DisplayMatrixWithCross(int[,] matrix)
        {
            int column = matrix.GetLength(1) - 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.ResetColor();
                    if (row == col)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (col == column)//if i use else if its not working for different array sizes
                    {
                        column = column - 1;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine("");
            }
            Console.ResetColor();
        }
    }
}
