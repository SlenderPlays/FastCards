using Avalonia.Controls;
using FastCards.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastCards.ViewModels
{
	public class MainWindowViewModel : ViewModelBase
	{

		private ViewModelBase innerViewModel = new MainControlViewModel();

		public ViewModelBase InnerViewModel
		{
			get => innerViewModel;
			private set => this.RaiseAndSetIfChanged(ref innerViewModel, value);

		}
	}
}
