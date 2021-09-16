using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    class SolarPanelDiisplay : IObserver
    {
        public SolarPanelDiisplay(IObservable observable)
        {
            observable.AddObserver(this);
        }

        public void Update(int watt)
        {
            Console.WriteLine($"new measurement: {watt}");
        }
    }
}
