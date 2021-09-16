using System;

namespace ConwayGameOfLife
{
    public interface ILifeBehaviour
    {
        bool CellShouldLive(bool livingCell, int neighbourCount);
    }
}
