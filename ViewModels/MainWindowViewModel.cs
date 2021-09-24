using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastCards.ViewModels
{
	public class MainWindowViewModel : ViewModelBase
	{
		private int clicks = 0;

		private string greeting = "Welcome to Avalonia!";

		public string Greeting
		{
			get => greeting;
			private set => this.RaiseAndSetIfChanged(ref greeting, value);

		}

		public void ButtonClicked()
		{
			clicks++;
			Greeting = $"You clicked the button {clicks} times!";
		}
	}
}
