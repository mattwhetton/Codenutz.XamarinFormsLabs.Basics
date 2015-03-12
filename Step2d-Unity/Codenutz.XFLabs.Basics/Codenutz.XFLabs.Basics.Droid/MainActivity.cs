using Android.App;
using Android.Content.PM;
using Android.OS;
using Codenutz.XFLabs.Basics.ViewModel;
using Microsoft.Practices.Unity;
using XLabs.Forms;
using XLabs.Ioc;
using XLabs.Platform.Device;

namespace Codenutz.XFLabs.Basics.Droid
{
	[Activity(Label = "Codenutz.XamarinFormsLabs.Basics", Icon = "@drawable/icon", MainLauncher = true,
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : XFormsApplicationDroid
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			if (!Resolver.IsSet) SetIoc();

			LoadApplication(new App());
		}

		private void SetIoc()
		{
			var container = new UnityContainer();

			container.RegisterInstance<IDevice>(AndroidDevice.CurrentDevice);
			container.RegisterType<MainViewModel>();

			Resolver.SetResolver(new XLabs.Ioc.Unity.UnityResolver(container));
		}
	}
}

