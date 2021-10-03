using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FastCards.Views
{
	public partial class Control2View : UserControl
	{
		public Control2View()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
