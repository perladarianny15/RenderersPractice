using System;
using System.ComponentModel;
using System.Windows.Input;
using RendererPractice.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RendererPractice.ViewModels
{
    public class TextToSpeechViewModel: INotifyPropertyChanged
    {
        public ICommand ToSpeak { get; set; }
        public string Text { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public TextToSpeechViewModel()
        {
            ToSpeak = new Command(async () =>
            {
                if(Text!= null)
                {
                    DependencyService.Get<ITextToSpeech>().Speak(Text);
                }
            });
            
        }
    }
}
