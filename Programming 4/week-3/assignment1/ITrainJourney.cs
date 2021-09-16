
namespace assignment1
{
    public interface ITrainJourney
    {
        TrainStation CurrentStation { get; }

        void AddObserver(ITrainDisplay observer);
        void RemoveObserver(ITrainDisplay observer);
        void NextStation();
    }
}
