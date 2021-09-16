using System;
using System.Collections.Generic;

namespace assignment4
{
    class AlarmSystem : IAlarmSystem
    {
        public DateTime AlarmDateTime { get; set; }
        public string AlarmMessage { get; private set; }

        private List<IAlarmObserver> observers;
        public AlarmSystem()
        {
            observers = new List<IAlarmObserver>();
            AlarmDateTime = DateTime.Now;
        }

        public void ActivateAlarm(string text)
        {
            AlarmMessage += text;
            NotifyObservers();
        }

        public void AddObserver(IAlarmObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IAlarmObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (IAlarmObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}
