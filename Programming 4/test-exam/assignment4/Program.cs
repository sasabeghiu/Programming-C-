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
            IObservable system = new SolarPanelSystem();
            IPanelController controller = new PanelController(system);
            IObserver display = new SolarPanelDiisplay(system);

            for (int i = 0; i < 10; i++)
            {
                controller.NewMeasurement();
            }
        }
    }
}
