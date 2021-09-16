using System;

namespace assignment4
{
    class AlarmController : IAlarmController
    {
        private IAlarmSystem alarmSystem;

        public AlarmController(IAlarmSystem alarmSystem)
        {
            this.alarmSystem = alarmSystem;
        }

        public void ActivateAlarm(string text)
        {
            alarmSystem.ActivateAlarm(text);
        }
    }
}
