using System;

namespace CandyCrushLogic
{
    public class CandyCrusher
    {
        public static bool ScoreColumnPresent(RegularCandies[,] playingField)
        {
            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                int counter = 1;
                RegularCandies currentCandy = playingField[0, row];
                for (int col = 1; col < playingField.GetLength(1); col++)
                {
                    if (currentCandy == playingField[col, row])
                    {
                        counter++;
                        if (counter >= 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                    currentCandy = playingField[col, row];
                }
            }
            return false;
        }
        public static bool ScoreRowPresent(RegularCandies[,] playingField)
        {
            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                int counter = 1;
                RegularCandies currentCandy = playingField[0, 0];
                for (int col = 1; col < playingField.GetLength(1); col++)
                {
                    if (currentCandy == playingField[row, col])
                    {
                        counter++;
                        if (counter >= 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                    currentCandy = playingField[row, col];
                }
            }
            return false;
        }
    }
}
