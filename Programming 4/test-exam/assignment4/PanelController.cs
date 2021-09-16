using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    class PanelController : IPanelController
    {
        private IObservable solarPanel;
        public PanelController(IObservable observable)
        {
            this.solarPanel = observable;
        }

        public void NewMeasurement()
        {
            solarPanel.NewMeasurement();
        }
    }
}
