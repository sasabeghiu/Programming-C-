using System;

namespace assignment3
{
    public class SimpleMP3Display : IObserver
    {
        public void Update(Song song)
        {
            Console.WriteLine($"Simple display: {song.Artist} - {song.Title}");
        }

        public SimpleMP3Display(IObservable player)
        {
            player.AddObserver(this);
        }
    }
}
