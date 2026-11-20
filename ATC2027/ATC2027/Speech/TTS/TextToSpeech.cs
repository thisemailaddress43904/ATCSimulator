using ATC2027.DataStructures;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATC2027.Speech.TTS
{
    public class TextToSpeech
    {

        private static TextToSpeech tts = new TextToSpeech(7, 75);
        public async static void Speak(string str)
        {
            Thread thread = new Thread(() => { tts.speak(str); });
            thread.Start();
        }

        SpeechSynthesizer ssAPI;
        IList<string> stringsToSpeak;
        static bool isSpeaking; //this is static because the SpeechSynthesizer might speak over itself and produce mangled up sound and to ensure that it only speaks one thing at a time, we need to know if it is currently speaking or not.
        public TextToSpeech(int rate, int volume)
        {
            ssAPI = new SpeechSynthesizer
            {
                Rate = rate,
                Volume = volume
            };
            ssAPI.SetOutputToDefaultAudioDevice();

            stringsToSpeak = [];

        }

        private void speak(string text)
        {
            isSpeaking = true;
            ssAPI.Speak(text);
            isSpeaking = false;
        }
    }
}