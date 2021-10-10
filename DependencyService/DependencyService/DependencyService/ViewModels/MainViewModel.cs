using System;
using System.Collections.Generic;
using System.Text;
using DependencyServicePracticaAS.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DependencyServicePracticaAS.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
        }

        public DeviceOrientation Orientation { get; set; }
    }
}
