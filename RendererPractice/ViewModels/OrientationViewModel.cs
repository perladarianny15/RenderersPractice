using System;
using System.ComponentModel;
using System.Windows.Input;
using RendererPractice.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RendererPractice.ViewModels
{
    public class OrientationViewModel : INotifyPropertyChanged
    {
        public ICommand ChangeOrientation { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public string Result;

        public OrientationViewModel()
        {
            ChangeOrientation = new Command(async () =>
            {
                IDeviceOrientationService service = DependencyService.Get<IDeviceOrientationService>();
                DeviceOrientation orientation = service.GetOrientation();
                Result = orientation.ToString();
            });
        }
    }
}
