using PowerLunch.Views;
using Prism.Unity;

namespace PowerLunch
{
	public partial class App : PrismApplication
	{
		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync(nameof(PowerLunchPage));
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<PowerLunchPage>();
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
