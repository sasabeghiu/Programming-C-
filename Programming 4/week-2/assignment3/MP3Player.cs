using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    public class MP3Player : IObservable
    {
        public Song CurrentSong { get; private set; }
        private List<IObserver> observers = new List<IObserver>();

        Random rnd = new Random();
        List<Song> songs;

        public MP3Player()
        {
            songs = new List<Song>();
            songs.Add(new Song("Papillon", "Editors", new TimeSpan(0, 5, 24)));
            songs.Add(new Song("Wish You Were Here", "Pink Floyd", new TimeSpan(0, 5, 39)));
            songs.Add(new Song("Dazed and Confused", "Led Zeppelin", new TimeSpan(0, 6, 26)));
            songs.Add(new Song("Billionaire", "Bruno Mars", new TimeSpan(0, 3, 31)));
        }

        public void NextSong()
        {
            CurrentSong = songs[rnd.Next(songs.Count)];
            //informs all subscribed observers
            foreach (IObserver observer in observers)
            {
                observer.Update(CurrentSong);
            }
            Console.WriteLine();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
