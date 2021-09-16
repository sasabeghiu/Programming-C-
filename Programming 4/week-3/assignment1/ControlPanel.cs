using System;
using System.Windows.Forms;

namespace assignment1
{
    public partial class ControlPanel : Form
    {
        private ITrainJourney journey;
        private ITrainController controller;
        private int counter;
        public ControlPanel()
        {
            InitializeComponent();
            journey = new TrainJourney();
            controller = new TrainController(journey);
            counter = 1;
        }

        private void btnNextStation_Click(object sender, EventArgs e)
        {
            controller.NextStation();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            TrainDisplay trainDisplay = new TrainDisplay(journey);
            trainDisplay.Text = String.Format("Train display #{0}", counter);
            trainDisplay.Show();
            counter++;
        }
    }
}
