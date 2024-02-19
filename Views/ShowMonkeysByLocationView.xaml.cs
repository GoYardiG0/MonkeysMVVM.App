using MonkeysMVVM.ViewModels;

namespace MonkeysMVVM.Views;

public partial class ShowMonkeysByLocationView : ContentPage
{
	public ShowMonkeysByLocationView(ShowMonkeysByLocationViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}