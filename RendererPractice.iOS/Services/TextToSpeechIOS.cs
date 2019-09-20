using System;
using AVFoundation;
using RendererPractice.iOS.Services;
using RendererPractice.Services;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechIOS))]

namespace RendererPractice.iOS.Services
{
    public class TextToSpeechIOS: ITextToSpeech
    {
        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 2,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 1f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}
