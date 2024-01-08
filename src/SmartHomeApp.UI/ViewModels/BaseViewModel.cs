using ReactiveUI;

namespace SmartHomeApp.UI.ViewModels;

public class BaseViewModel : ReactiveObject, IActivatableViewModel
{
    public ViewModelActivator Activator { get; } = new();
}
