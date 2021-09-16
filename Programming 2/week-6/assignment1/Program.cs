using System;

namespace assignment1
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
            ChessPiece[,] chessboard = new ChessPiece[8, 8];
            InitChessboard(chessboard);
            DisplayChessboard(chessboard);
            PlayChess(chessboard);
        }
        void InitChessboard(ChessPiece[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = null;
                }
            }
            PutChessPieces(chessboard);
        }
        void DisplayChessboard(ChessPiece[,] chessboard)
        {
            int count = 8;
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                Console.Write(" {0} ", count);
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    DisplayChessPiece(chessboard[row, col]);
                    Console.ResetColor();
                }
                Console.WriteLine();
                count--;
            }
            Console.WriteLine("    a  b  c  d  e  f  g  h");
        }
        void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order =
            {
                ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.Queen, ChessPieceType.King,
                ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook
            };
            for (int col = 0; col < chessboard.GetLength(0); col++)
            {
                chessboard[0, col] = new ChessPiece() { color = ChessPieceColor.Black, type = order[col] };
                chessboard[1, col] = new ChessPiece() { color = ChessPieceColor.Black, type = ChessPieceType.Pawn };
                chessboard[7, col] = new ChessPiece() { color = ChessPieceColor.White, type = order[col] };
                chessboard[6, col] = new ChessPiece() { color = ChessPieceColor.White, type = ChessPieceType.Pawn };
            }
        }
        void DisplayChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece != null)
            {
                if (chessPiece.color == ChessPieceColor.Black)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                string text = chessPiece.type.ToString();
                if ((chessPiece.type != ChessPieceType.King) && (chessPiece.type != ChessPieceType.Queen))
                {
                    text = text.ToLower();
                }
                Console.Write($" {text[0]} ");
            }
            else
            {
                Console.Write("   ");
            }
        }
        Position String2Position(string pos)
        {
            int column = pos[0] - 'a';
            int row = 8 - int.Parse(pos[1].ToString());
            if (column < 0 || column > 7 || row < 0 || row > 7)
            {
                throw new Exception($"invalid position: {pos}");
            }
            Position position = new Position();
            position.row = row;
            position.column = column;
            return position;
        }
        void PlayChess(ChessPiece[,] chessboard)
        {
            string move = "";
            while (move != "stop")
            {
                try
                {
                    Console.WriteLine("Enter move (e.g. a2 a3): ");
                    move = Console.ReadLine();
                    if (move == "stop")
                    {
                        break;
                    }
                    string[] fields = move.Split(' ');
                    Position from = String2Position(fields[0]);
                    Position to = String2Position(fields[1]);
                    Console.WriteLine($"move from {fields[0]} to {fields[1]}");
                    DoMove(chessboard, from, to);
                    DisplayChessboard(chessboard);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        void DoMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            CheckMove(chessboard, from, to);
            chessboard[to.row, to.column] = chessboard[from.row, from.column];
            chessboard[from.row, from.column] = null;
        }
        void CheckMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            ChessPiece chesspieceFrom = chessboard[from.row, from.column];
            ChessPiece chesspieceTo = chessboard[to.row, to.column];
            if (chesspieceFrom == null)
            {
                throw new Exception("No chess piece at from-position");
            }
            if (chesspieceTo != null)
            {
                if (chesspieceTo.color == chesspieceFrom.color)
                {
                    throw new Exception("Can not take a chess piece of same color");
                }
            }
            int hor = Math.Abs(from.column - to.column);
            int ver = Math.Abs(from.row - to.row);
            bool validMove = false;
            if (hor == 0 && ver == 0)
            {
                throw new Exception("No movement");
            }
            switch (chesspieceFrom.type)
            {
                case ChessPieceType.Rook:
                    validMove = (hor * ver == 0);
                    break;
                case ChessPieceType.Knight:
                    validMove = (hor * ver == 2);
                    break;
                case ChessPieceType.Bishop:
                    validMove = (hor == ver);
                    break;
                case ChessPieceType.King:
                    validMove = ((hor == 1 || ver == 1));
                    break;
                case ChessPieceType.Queen:
                    validMove = ((hor * ver == 0 || hor == ver));
                    break;
                case ChessPieceType.Pawn:
                    validMove = ((hor == 0 && ver == 1));
                    break;
                default: throw new Exception($"Invalid move for chess piece {chesspieceFrom.type}");
            }
            if (!validMove)
            {
                throw new Exception($"Invalid move for chess piece {chesspieceFrom.type}");
            }
        }
    }
}

