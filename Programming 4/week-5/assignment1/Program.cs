using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadLine();
        }

        private void Start()
        {
            Logger logger = Logger.GetInstance();
            MainSystem mainSystem = new MainSystem();

            logger.Log("main", "starting");
            mainSystem.DoSomeMainWork();
            logger.Log("main", "finishing");
        }
    }
}
