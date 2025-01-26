using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal interface IPlayable
    {
        void play();
    }
    class VideoPlayer : IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing Video...");
        }
    }

    class MusicPlayer : IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing Music...");
        }
    }

    internal interface Interface1
    {
        public static void Main()
        {
            IPlayable videoPlayer = new VideoPlayer();
            videoPlayer.play();
            IPlayable musicPlayer = new MusicPlayer();
            musicPlayer.play();
        }

    }
}
