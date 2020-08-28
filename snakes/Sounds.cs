using System;
using System.Collections.Generic;
using System.Text;

namespace snakes
{
    class Sounds
    {
      
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play()
        {
            player.URL = pathToMedia + "2.mp3";
            player.settings.volume = 20;
            player.controls.play();
            player.settings.setMode("loop", true);
        }

        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + "3.mp3";
            player.controls.play();
        }

        public void PlayEat()
        {
            player.URL = pathToMedia + "2.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }

        public void PlayNo()
        {
            player.URL = pathToMedia + "1.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
        public void Stop()
        {
            player.URL = pathToMedia + "3.mp3";
            player.controls.stop();
        }
        public void Stop(string songName)
        {
            player.URL = pathToMedia + songName + "1.mp3";
            player.controls.stop();
        }
    }
}

