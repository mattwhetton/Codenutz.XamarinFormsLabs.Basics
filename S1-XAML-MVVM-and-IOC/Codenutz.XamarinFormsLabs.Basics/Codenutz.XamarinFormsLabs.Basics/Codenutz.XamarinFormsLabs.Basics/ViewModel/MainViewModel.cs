using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codenutz.XamarinFormsLabs.Basics.ViewModel
{
	public class MainViewModel : Xamarin.Forms.Labs.Mvvm.ViewModel
	{
		private string _message;


		public MainViewModel()
		{
			Message = "Hello Xamarin Forms Labs MVVM Basics!!";
		}

		public string Message
		{
			get { return _message; }
			set { SetProperty(ref _message, value); }
		}
	}
}
