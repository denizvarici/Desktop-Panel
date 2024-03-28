using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.CoreAudioApi;

namespace Panel.UI.SoundControl
{
    public class SoundController
    {
        private MMDevice defaultDevice;

        public SoundController()
        {
            var enumerator = new MMDeviceEnumerator();
            defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        }

        public float GetCurrentSoundLevel()
        {
            return defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar;
        }

        public void SetSoundLevel(float sesSeviyesi) // 0-1 arası float
        {
            defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = sesSeviyesi *0.01f;
        }
    }
}
