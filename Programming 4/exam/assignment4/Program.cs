using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        private void Start()
        {
            //MVC pattern

            // create alarm system
            IAlarmSystem alarmSystem = new AlarmSystem();
            // create controller
            IAlarmController controller = new AlarmController(alarmSystem);
            // create displays
            IAlarmObserver display1 = new AlarmDisplay(alarmSystem);
            IAlarmObserver display2 = new AlarmExtendedDisplay(alarmSystem);

            // activate the alarm system a few times (for testing)
            controller.ActivateAlarm("backdoor is open");
            Console.WriteLine();
            controller.ActivateAlarm("smoke in room H-10");
            Console.WriteLine();

        }
    }
}
