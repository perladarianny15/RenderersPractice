using System;
using Android.Speech.Tts;
using RendererPractice.Droid.Services;
using RendererPractice.Services;
using Xamarin.Forms;
using static Android.Speech.Tts.TextToSpeech;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechDroid))]
namespace RendererPractice.Droid.Services
{
    public class TextToSpeechDroid : Java.Lang.Object, ITextToSpeech, IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public void Speak(string text)
        {
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(Forms.Context, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

    }

}
