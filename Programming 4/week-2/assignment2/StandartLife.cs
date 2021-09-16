﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConwayGameOfLife
{
    public class StandartLife : ConwayGameOfLife
    {
        public override bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // B3/S23

            // a cell is born if it has 3 neighbors
            if (!livingCell && neighbourCount == 3)
                return true;

            // a cell survives if it has 2 or 3 neighbors
            if (livingCell && (neighbourCount == 2 || neighbourCount == 3))
                return true;

            // dead cell
            return false;

        }
    }
}
