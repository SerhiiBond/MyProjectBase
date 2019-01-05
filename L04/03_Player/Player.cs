using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Player
{
    class Player : IRecordable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing - started");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Playing - paused");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Playing - stoped");
        }
        public void Record()
        {
            Console.WriteLine("Recording - started");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Recording - stoped");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Recording - paused");
        }
    }
}
