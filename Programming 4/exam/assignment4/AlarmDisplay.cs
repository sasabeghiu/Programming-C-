using System;

namespace assignment4
{
    class AlarmDisplay : IAlarmObserver
    {
        private IAlarmSystem alarmSystem;

        public AlarmDisplay(IAlarmSystem alarmSystem)
        {
            alarmSystem.AddObserver(this);
        }

        public void Update()
        {
            Console.WriteLine($"[alarm-display]: alarm activated at {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
        }
    }
}
