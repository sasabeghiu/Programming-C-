using System;

namespace assignment1
{
    abstract class BaseHouse
    {
        public void BuildHouse()
        {
            BuildingFoundation();
            BuildingWalls();
            BuildingRoof();
            PlacingWindows();
        }

        public void BuildingFoundation()
        {
            Console.WriteLine("building foundation");
        }

        public abstract void BuildingWalls();

        public abstract void BuildingRoof();

        public void PlacingWindows()
        {
            Console.WriteLine("placing windows");
        }
    }
}
