using Avalonia.ReactiveUI;

using SmartHomeApp.UI.ViewModels;

namespace SmartHomeApp.UI.Views;

public partial class LoungeAndKitchenView : ReactiveUserControl<LoungeAndKitchenViewModel>
{
    public LoungeAndKitchenView()
    {
        InitializeComponent();
    }
}