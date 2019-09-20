using System;
using System.Collections.Generic;
using RendererPractice.ViewModels;
using Xamarin.Forms;

namespace RendererPractice.Views
{
    public partial class ToSpeakPage : ContentPage
    {
        public ToSpeakPage()
        {
            InitializeComponent();
            BindingContext = new TextToSpeechViewModel();
        }
    }

}
