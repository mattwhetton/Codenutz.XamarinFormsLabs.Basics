using Foundation;
using UIKit;
using XLabs.Ioc;

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
			var resolverContainer = new SimpleContainer();
			Resolver.SetResolver(resolverContainer.GetResolver());
		}
	}
}
