using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Ticket
    {
        private string moviename;
        private int cinemaroom;
        private DateTime starttime;
        private int minimumage;
        public string MovieName
        {
            get { return moviename; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Empty movie name!");
                }
                this.moviename = value;
            }
        }

        public int CinemaRoom
        {
            get { return cinemaroom; }
            set
            {
                if (value > 5 || value < 1)
                {
                    throw new Exception("Invalid cinema room!");
                }
                this.cinemaroom = value;
            }
        }

        public DateTime StartTime
        {
            get { return starttime; }
            set
            {
                if (value.Minute != 00 && value.Minute != 30)//starts at 20:00 or 20:30
                {
                    throw new Exception("Invalid start time! ");
                }
                this.starttime = value;
            }
        }

        public decimal Price { get; set; }

        public int MinimumAge
        {
            get { return minimumage; }
            set
            {
                if (value != 0 && value != 6 && value != 9 && value != 12 && value != 16)
                {
                    throw new Exception("Invalid minimum age! ");
                }
                this.minimumage = value;
            }
        }

        public Ticket(string movieName, decimal price)
        {
            this.MovieName = movieName;
            this.Price = price;
        }
        public bool Discount
        {
            get
            {
                return (StartTime.DayOfWeek == DayOfWeek.Monday || StartTime.DayOfWeek == DayOfWeek.Tuesday);
            }

        }

        public override string ToString()
        {
            return $"created ticket '{MovieName}', start time: {StartTime:dd/MM/yyyy H:mm}, price: {Price:0.00}, room: {CinemaRoom} ({MinimumAge}+)";
        }
    }
}
