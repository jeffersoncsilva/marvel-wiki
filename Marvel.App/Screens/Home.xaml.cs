using Mavel.ViewModels.Screens;

namespace Marvel.App.Screens;

public partial class Home : ContentPage
{
	private readonly HomeViewModel _vm;
	public Home(HomeViewModel vm)
	{
		_vm = vm;
		BindingContext = vm;
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		_vm.OnAppearing();
    }
}