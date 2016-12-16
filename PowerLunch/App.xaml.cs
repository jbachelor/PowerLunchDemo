using Xamarin.Forms;
using PowerLunch.Views;

namespace PowerLunch
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new PowerLunchPage(); // This is where we set the opening view on app launch.
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
