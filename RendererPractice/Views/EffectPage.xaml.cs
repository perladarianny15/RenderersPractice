using System;
using System.Collections.Generic;
using RendererPractice.ViewModels;
using Xamarin.Forms;

namespace RendererPractice.Views
{
    public partial class EffectPage : ContentPage
    {
        public EffectPage()
        {
            InitializeComponent();
            BindingContext = new EffectViewModel();
        }
    }
}
