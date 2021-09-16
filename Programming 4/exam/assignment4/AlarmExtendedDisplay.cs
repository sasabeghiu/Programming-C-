using System;

namespace assignment4
{
    class AlarmExtendedDisplay : IAlarmObserver
    {
        private AlarmSystem alarmSystem;

        public AlarmExtendedDisplay(IAlarmSystem alarmSystem)
        {
            alarmSystem.AddObserver(this);
            this.alarmSystem= new AlarmSystem();
        }

        public void Update()
        {
            //cant use the properties
            Console.WriteLine($"[extended alarm-display]: alarm activated at {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - backdoor is open");
        }
    }
}
