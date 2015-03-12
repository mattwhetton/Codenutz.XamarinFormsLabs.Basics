using System;
using XLabs.Platform.Device;

namespace Codenutz.XFLabs.Basics.ViewModel
{
	public class MainViewModel : XLabs.Forms.Mvvm.ViewModel
	{
		private readonly IDevice _device;
		private string _message;

		public MainViewModel(IDevice device)
		{
			_device = device;
			Message = String.Format("Hello Xamarin Forms Labs MVVM Basics!! How is your {0} device", device.Manufacturer);
		}

		public string Message
		{
			get { return _message; }
			set { SetProperty(ref _message, value); }
		}
	}
}
