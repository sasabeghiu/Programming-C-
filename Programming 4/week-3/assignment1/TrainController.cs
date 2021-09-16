
namespace assignment1
{
    public class TrainController : ITrainController
    {
        private ITrainJourney trainJourney;

        public TrainController(ITrainJourney trainJourney)
        {
            this.trainJourney = trainJourney;
        }

        public void NextStation()
        {
            trainJourney.NextStation();
        }
    }
}
