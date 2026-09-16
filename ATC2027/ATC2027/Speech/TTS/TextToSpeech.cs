using ATC2027.DataStructures;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Speech.TTS
{
    public class TextToSpeech
    {
        SpeechSynthesizer ssAPI;
        ConcurrentPriorityQueue<string> stringsToSpeak;
        static bool isSpeaking; //this is static because the SpeechSynthesizer might speak over itself and produce mangked up sound and to ensure that it only speaks one thing at a time, we need to know if it is currently speaking or not.
        public TextToSpeech(int rate, int volume)
        {
            ssAPI = new SpeechSynthesizer
            {
                Rate = rate,
                Volume = volume
            };
            ssAPI.SetOutputToDefaultAudioDevice();

            stringsToSpeak = new ConcurrentPriorityQueue<string>();

        }

        private void speak(string text)
        {
            isSpeaking = true;
            ssAPI.Speak(text);
            isSpeaking = false;
        }

        /**
         * Speak all the strings in the queue one after another.
         */
        public async void speakAll()
        {
            lock (stringsToSpeak)
            {
                while (!stringsToSpeak.IsEmpty)
                {
                    if (stringsToSpeak.TryDequeue(out string text))
                    {
                        //wait for speaking to stop
                        while (isSpeaking) ;

                        //speak text
                        Task.Run(() => speak(text));
                    }
                }
            }
        }

        public async void AddNewHead(string text)
        {
            lock (stringsToSpeak)
            {
                this.stringsToSpeak.Append(text);
            }
        }

        public async void AddToEnd(string text, int priority)
        {
            lock (stringsToSpeak)
            {
                this.stringsToSpeak.Enqueue(text, priority);
            }

        }
    }
}