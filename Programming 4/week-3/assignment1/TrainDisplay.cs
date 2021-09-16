using System;
using System.Windows.Forms;

namespace assignment1
{
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        private ITrainJourney journey;
        public TrainDisplay(ITrainJourney journey)
        {
            InitializeComponent();
            this.journey = journey;
            this.journey.AddObserver(this);
        }

        private void TrainDisplay_Load(object sender, EventArgs e)
        {
            lblCurrentStation.Text = journey.CurrentStation.Name;
            lblRailway.Text = journey.CurrentStation.ArrivalTrack.ToString();
        }

        public void Update(TrainStation trainStation)
        {
            lblCurrentStation.Text = trainStation.Name;
            lblRailway.Text = trainStation.ArrivalTrack;
        }
    }
}
