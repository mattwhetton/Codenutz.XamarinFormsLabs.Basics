using Microsoft.Phone.Controls;

namespace Codenutz.XFLabs.Basics.WinPhone
{
	public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
	{
		public MainPage()
		{
			InitializeComponent();
			SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

			global::Xamarin.Forms.Forms.Init();
			LoadApplication(new XFLabs.Basics.App());
		}
	}
}
