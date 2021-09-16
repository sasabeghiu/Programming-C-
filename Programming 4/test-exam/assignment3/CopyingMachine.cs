using System;

namespace assignment3
{
    class CopyingMachine
    {
        private static CopyingMachine uniqueInstance;
        private int totalNumberOfCopies;
        public int TotalNumberOfCopies { get { return totalNumberOfCopies; } }

        private CopyingMachine()
        {

        }

        public static CopyingMachine GetUniqueInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new CopyingMachine();
            }
            return uniqueInstance;
        }

        public void Copy(int nrCopies)
        {
            totalNumberOfCopies += nrCopies;
            Console.WriteLine($"copying, {nrCopies}x");
            Console.WriteLine($"total number of copies: {totalNumberOfCopies}x");
        }
    }
}
