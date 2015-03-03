using Android.App;
using Android.Content.PM;
using Android.OS;
using Codenutz.XFLabs.Basics.ViewModel;
using XLabs.Forms;
using XLabs.Ioc;
using XLabs.Platform.Device;

namespace Codenutz.XFLabs.Basics.Droid
{
	[Activity(Label = "Codenutz.XamarinFormsLabs.Basics", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : XFormsApplicationDroid
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			if(!Resolver.IsSet) SetIoc();

			LoadApplication(new App());
		}

	private void SetIoc()
	{
		var resolverContainer = new SimpleContainer();

		resolverContainer.Register<IDevice>(r => AndroidDevice.CurrentDevice);
		resolverContainer.Register<MainViewModel>(r => new MainViewModel(r.Resolve<IDevice>()));

		Resolver.SetResolver(resolverContainer.GetResolver());
	}
	}
}

