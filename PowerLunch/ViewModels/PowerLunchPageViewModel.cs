using System;
using System.ComponentModel;
using System.Diagnostics;

namespace PowerLunch.ViewModels
{
	class PowerLunchPageViewModel : INotifyPropertyChanged
	{
		/// <summary>
		/// The number of times the button has been pressed.
		/// </summary>
		private int clickCount;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PowerLunch.PowerLunchPageViewModel"/> class.
		/// </summary>
		public PowerLunchPageViewModel()
		{
			Debug.WriteLine($"{nameof(PowerLunchPageViewModel)}.ctor -- Constructing {nameof(PowerLunchPageViewModel)}");
			ClickCountText = "0 Clicks (snooooze...)";
		}

		/// <summary>
		/// Private field storing the text of the label displaying the number of clicks.
		/// </summary>
		private string _clickCountText;
		/// <summary>
		/// Property exposing getter and setter for the click count text.
		/// </summary>
		/// <value>The click count text.</value>
		public string ClickCountText
		{
			get { return _clickCountText; }
			set
			{
				if (value != _clickCountText)
				{
					_clickCountText = value;
					OnPropertyChanged(nameof(ClickCountText));
				}

			}
		}

		/// <summary>
		/// Private field storing the click count rotation.
		/// </summary>
		private int _clickCountRotation;
		/// <summary>
		/// Property exposing getter and setter for the click count rotation.
		/// </summary>
		/// <value>The click count rotation.</value>
		public int ClickCountRotation
		{
			get { return _clickCountRotation; }
			set
			{
				if (value != _clickCountRotation)
				{
					if (value >= 360)
					{
						value = 0;
					}
					_clickCountRotation = value;
					OnPropertyChanged(nameof(ClickCountRotation));
					Debug.WriteLine($"{nameof(PowerLunchPageViewModel)}.ClickCountRotation:  {_clickCountRotation}");
				}
			}
		}

		/// <summary>
		/// This button click handler is fired off from the view's code-behind file (PowerLunchPage.xaml.cs).
		/// A stricter MVVM implementation would probably use a commanding pattern:
		/// https://blog.xamarin.com/simplifying-events-with-commanding/
		/// </summary>
		internal void ClickBaitButtonHandler()
		{
			clickCount++;
			ClickCountRotation += 10;
			ClickCountText = $"{clickCount} clicks!";
		}

		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;
		/// <summary>
		/// Call OnPropertyChanged on any ViewModel property that is exposed in the View (PowerLunchPage.xaml).
		/// This is the foundation of "Data Binding", and allows the view to always stay in sync with the 
		/// value of it's properties, without any need to "refresh" the view to reflect updated content.
		/// It's pretty rad.
		/// </summary>
		/// <param name="propertyName">Name of property that changed.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{
			var changed = PropertyChanged;
			if (changed != null)
			{
				Debug.WriteLine($"{nameof(PowerLunchPageViewModel)}.OnPropertyChanged event fired for {propertyName}");
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
			else {
				Debug.WriteLine($"{nameof(PowerLunchPageViewModel)}.OnPropertyChanged was called, but PropertyChanged handler was null.");
			}
		}

		#endregion INotifyPropertyChanged
	}
}
