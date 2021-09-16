using System;
using System.Collections.Generic;

namespace assignment4
{
    class SolarPanelSystem : IObservable
    {
        private List<IObserver> observers;
        private Random random;
        public int Power { get; private set; }

        public SolarPanelSystem()
        {
            observers = new List<IObserver>();
            random = new Random();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NewMeasurement()
        {
            Power = random.Next(300, 400);
            NotifyObservers();
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(Power);
            }
        }
    }
}
