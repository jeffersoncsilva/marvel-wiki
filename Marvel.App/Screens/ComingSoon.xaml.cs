using Mavel.ViewModels.Screens;

namespace Marvel.App.Screens;

public partial class ComingSoon : ContentPage
{
	private readonly ComingSoonViewModel _vm;


    public ComingSoon(ComingSoonViewModel vm)
	{
		_vm = vm;
		BindingContext = _vm;
		InitializeComponent();
	}
}