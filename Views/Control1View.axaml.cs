using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FastCards.Views
{
	public partial class Control1View : UserControl
	{
		public Control1View()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
