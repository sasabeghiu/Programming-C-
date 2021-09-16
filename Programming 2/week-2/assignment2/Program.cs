using System;

namespace assignment2
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
            InitMatrixRandom(matrix, 1, 100);
            DisplayMatrix(matrix);
            Console.Write("Enter a number (to search for): ");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            Position pos = new Position();
            Position backpos = new Position();
            pos = SearchNumber(matrix, value);
            backpos = SearchNumberBackwards(matrix, value);
            Console.WriteLine("Number {0} is found (first) at position [{1}, {2}] ", value, pos.row, pos.col);
            
            Console.WriteLine("Number {0} is found (last) at position [{1}, {2}] ", value, backpos.row, backpos.col);
            Console.ReadLine();
        }
        //fill the matrix with random numbers between min and max
        void InitMatrixRandom(int[,] matrix, int min, int max)
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
        //copied from previous assignment
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
        class Position
        {
            public int row;
            public int col;
        }
        //search number from top to bottom
        Position SearchNumber(int[,] matrix, int number)
        {
            Position pos = new Position();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == number)
                    {
                        pos.row = i;
                        pos.col = j;
                        return pos;
                    }
                }
            }
            return pos;
        }
        //search number from bottom to top
        Position SearchNumberBackwards(int[,] matrix, int number)
        {
            Position backpos = new Position();

            for (int i =  matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j =  matrix.GetLength(1) - 1; j >=  0; j--)
                {
                    if (matrix[i,j] == number)
                    {
                        backpos.row = i;
                        backpos.col = j;
                        return backpos;
                    }
                }
            }
            return backpos;
        }
    }
}
