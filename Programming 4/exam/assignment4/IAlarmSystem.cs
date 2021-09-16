using System;

namespace assignment4
{
    interface IAlarmSystem
    {
        void ActivateAlarm(string text);
        void AddObserver(IAlarmObserver observer);
        void RemoveObserver(IAlarmObserver observer);
    }
}
