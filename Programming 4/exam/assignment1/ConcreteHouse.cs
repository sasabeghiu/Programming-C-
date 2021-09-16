using System;

namespace assignment1
{
    class ConcreteHouse : BaseHouse
    {
        public override void BuildingRoof()
        {
            Console.WriteLine("building concrete roof");
        }

        public override void BuildingWalls()
        {
            Console.WriteLine("building concrete walls");
        }
    }
}
