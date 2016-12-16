using System.ComponentModel;
using PowerLunch.ViewModels;
using Xamarin.Forms;

namespace PowerLunch.Views
{
	public partial class PowerLunchPage : ContentPage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:PowerLunch.PowerLunchPage"/> class.
		/// In a strict MVVM app, this constructor would most likely be the ONLY method in
		/// this class, and it would contain only the line, "InitializeComponent();".
		/// To simplify things a bit in order to fit this tutorial (hopefull) into an hour,
		/// we will set the "BindingContext" of the view here, rather than using an MVVM
		/// framework such as Prism or MVVMCross:
		/// https://mvvmcross.com/
		/// https://github.com/PrismLibrary/Prism-Samples-Forms
		/// </summary>
		public PowerLunchPage()
		{
			InitializeComponent();
			this.BindingContext = new PowerLunchPageViewModel();
		}

		/// <summary>
		/// Click handler for the 'ClickBaitButton' button
		/// </summary>
		void ClickBaitButtonPress(object sender, System.EventArgs e)
		{
			var viewModel = (PowerLunchPageViewModel)BindingContext;
			viewModel.ClickBaitButtonHandler();
		}
	}
}
