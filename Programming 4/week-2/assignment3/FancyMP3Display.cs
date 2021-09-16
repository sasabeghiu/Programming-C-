using System;

namespace assignment3
{
    public class FancyMP3Display : IObserver
    {
        public void Update(Song song)
        {
            Console.WriteLine($"Fancy display: {song.Title} by {song.Artist} ({song.Duration.ToString("mm\\:ss")})");
        }

        public FancyMP3Display(IObservable player)
        {
            player.AddObserver(this);
        }
    }
}
