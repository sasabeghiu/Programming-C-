using System;
using System.Collections.Generic;

namespace assignment1
{
    public class TrainJourney : ITrainJourney
    {
        private List<TrainStation> stations;
        private TrainStation currentStation;
        private List<ITrainDisplay> observers;
        private int counter;

        public TrainStation CurrentStation
        {
            get
            {
                return currentStation;
            }
        }

        public TrainJourney()
        {
            stations = new List<TrainStation>();
            observers = new List<ITrainDisplay>();

            stations.Add(new TrainStation("Den Helder", "2a", DateTime.Parse("14:33"), DateTime.Parse("14:34")));
            stations.Add(new TrainStation("Den Helder Zuid", "1a", DateTime.Parse("14:38"), DateTime.Parse("14:38")));
            stations.Add(new TrainStation("Anna Paulowna", "1b", DateTime.Parse("14:44"), DateTime.Parse("14:45")));
            stations.Add(new TrainStation("Schagen", "1b", DateTime.Parse("14:52"), DateTime.Parse("14:52")));
            stations.Add(new TrainStation("Heerhugowaard", "1a", DateTime.Parse("15:01"), DateTime.Parse("15:02")));
            stations.Add(new TrainStation("Alkmaar Noord", "1a", DateTime.Parse("15:07"), DateTime.Parse("15:08")));
            stations.Add(new TrainStation("Alkmaar", "5a", DateTime.Parse("15:11"), DateTime.Parse("15:14")));
            //current station is the fiirst station
            currentStation = stations[0];
        }

        public void NextStation()
        {
            //reverse the lsit of sttations if counter =nr of stattionss
            if (counter >= stations.Count-1)
            {
                stations.Reverse();
                counter = 0;
            }
            counter += 1;
            currentStation = stations[counter];
            NotifyObservers();
        }

        public void AddObserver(ITrainDisplay observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(ITrainDisplay observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (ITrainDisplay observer in observers)
            {
                observer.Update(CurrentStation);
            }
        }
    }
}
