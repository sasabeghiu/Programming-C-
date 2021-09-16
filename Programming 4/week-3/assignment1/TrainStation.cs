using System;

namespace assignment1
{
    public class TrainStation
    {
        public string Name { get; set; }
        public string ArrivalTrack { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }

        public TrainStation(string name, string arriivalTrack, DateTime arrivalTime, DateTime departureTime)
        {
            this.Name = name;
            this.ArrivalTrack = arriivalTrack;
            this.ArrivalTime = arrivalTime;
            this.DepartureTime = departureTime;
        }
    }
}
