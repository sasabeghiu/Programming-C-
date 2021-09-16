using System;

namespace assignment1
{
    class WoodenHouse : BaseHouse
    {
        public override void BuildingRoof()
        {
            Console.WriteLine("building wooden roof");
        }

        public override void BuildingWalls()
        {
            Console.WriteLine("building wooden walls");
        }
    }
}
