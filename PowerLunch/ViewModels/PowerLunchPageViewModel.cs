using System;
using System.ComponentModel;
using System.Diagnostics;
using Prism.Commands;
using Prism.Mvvm;

namespace PowerLunch.ViewModels
{
	class PowerLunchPageViewModel : BindableBase
	{
		public DelegateCommand ClickerooCommand { get; set; }

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

			ClickerooCommand = new DelegateCommand(ClickBaitButtonHandler);

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
				SetProperty(ref _clickCountText, value);
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
					SetProperty(ref _clickCountRotation, value);
					Debug.WriteLine($"{nameof(PowerLunchPageViewModel)}.ClickCountRotation:  {_clickCountRotation}");
				}
			}
		}

		internal void ClickBaitButtonHandler()
		{
			clickCount++;
			ClickCountRotation += 10;
			ClickCountText = $"{clickCount} clicks!";
		}
	}
}
