using System;
using System.Collections.Generic;
using RendererPractice.ViewModels;
using Xamarin.Forms;

namespace RendererPractice.Views
{
    public partial class OrientationPage : ContentPage
    {
        public OrientationPage()
        {
            InitializeComponent();
            BindingContext = new OrientationViewModel();
        }
    }
}
