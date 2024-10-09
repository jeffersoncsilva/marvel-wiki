using Mavel.ViewModels.Screens;

namespace Marvel.App.Screens;

public partial class Favorits : ContentPage
{
	private readonly FavoritsViewModel _vm;
	public Favorits(FavoritsViewModel vm)
	{
		_vm = vm;
		BindingContext = _vm;
		InitializeComponent();
	}
}