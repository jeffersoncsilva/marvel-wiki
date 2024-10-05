using CommunityToolkit.Mvvm.ComponentModel;

namespace Mavel.ViewModels;

public abstract partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _title;
    [ObservableProperty]
    private bool _isBusy;

    public virtual void OnAppearing() { }

    public virtual void OnDesappearing() { }
}
