using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    interface IObservable
    {
        void NewMeasurement();
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
    }
}
