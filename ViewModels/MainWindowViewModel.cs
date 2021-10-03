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

		public ViewModelBase content = new Control1ViewModel();

		public ViewModelBase Content
		{
			get => content;
			private set => this.RaiseAndSetIfChanged(ref content, value);

		}

		public void Switch()
		{
			if (Content is Control1ViewModel) Content = new Control2ViewModel();
			else Content = new Control1ViewModel();
		}
	}
}
