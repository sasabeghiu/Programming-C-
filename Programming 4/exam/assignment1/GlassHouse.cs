using System;

namespace assignment1
{
    class GlassHouse : BaseHouse
    {
        public override void BuildingRoof()
        {
            Console.WriteLine("building glass roof");
        }

        public override void BuildingWalls()
        {
            Console.WriteLine("building glass walls");
        }
    }
}
