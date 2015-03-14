using Codenutz.XFLabs.Basics.ViewModel;
using Foundation;
using TinyIoC;
using UIKit;
using XLabs.Ioc;
using XLabs.Platform.Device;

namespace Codenutz.XFLabs.Basics.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : XLabs.Forms.XFormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			if (!Resolver.IsSet)
				SetIoc();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}

		private void SetIoc()
		{
			var container = TinyIoCContainer.Current;

			container.Register<IDevice>(AppleDevice.CurrentDevice);
			
			Resolver.SetResolver(new XLabs.Ioc.TinyIOC.TinyResolver(container));
		}
	}
}
