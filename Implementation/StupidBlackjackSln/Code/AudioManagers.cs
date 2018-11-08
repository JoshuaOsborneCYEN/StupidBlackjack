using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidBlackjackSln.Code
{
    class AudioManagers
    {
        private static System.Media.SoundPlayer effectsPlayer;
        private static System.Media.SoundPlayer musicPlayer;

        public static void PlayMusic(System.IO.Stream stream)
        {
            if(musicPlayer == null)
            {
                musicPlayer = new System.Media.SoundPlayer();
            }
            musicPlayer.Stop();
            musicPlayer.Stream = stream;
            musicPlayer.Load();
            musicPlayer.PlayLooping();
        }

        public static void PlaySoundEffect(System.IO.Stream stream)
        {
            if (effectsPlayer == null)
            {
                effectsPlayer = new System.Media.SoundPlayer();
            }
            effectsPlayer.Stop();
            effectsPlayer.Stream = stream;
            effectsPlayer.Load();
            effectsPlayer.Play();
        }
    }
}
