
namespace assignment1
{
    public class MainSystem
    {
        private Logger logger;
        private SubSystem subSystem;

        public MainSystem()
        {
            logger = Logger.GetInstance();
            subSystem = new SubSystem();
        }

        public void DoSomeMainWork()
        {
            logger.Log("MainSystem", "doing some main work");
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }
    }
}
