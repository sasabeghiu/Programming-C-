﻿
namespace assignment3
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NextSong();
    }
}
