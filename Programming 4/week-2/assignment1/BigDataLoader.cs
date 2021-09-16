using System;

namespace assignment1
{
    public abstract class BigDataLoader
    {
        public void ETL()
        {
            Extract();
            Transform();
            Load();
        }

        public abstract void Extract();
        public abstract void Transform();
        public void Load()
        {
            Console.WriteLine("loading transformed data...");
        }
    }
}
